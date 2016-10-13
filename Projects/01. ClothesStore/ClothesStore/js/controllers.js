/* globals templatesLoader, data, Handlebars */

var controllers = (function () {

    function getSum(array) {
        var sum = 0;

        array.forEach(function (item) {
            sum += item.price;
        });

        return sum;
    }

    function filterByName(categoryArray, searchWord) {
        var len = categoryArray.length;
        for (var i = 0; i < len; i += 1) {
            var $currentItem = $(categoryArray[i]);
            if ($currentItem.html().toLowerCase().indexOf(searchWord.toLowerCase()) < 0) {
                $currentItem.parent().parent().addClass('filter');
            } else {
                $currentItem.parent().parent().removeClass('filter');
            }
        }
    }

    function home() {
        templatesLoader.get('home')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate());
            });
    }

    function map() {
        templatesLoader.get('googleMap')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate());
            });
    }

    function register() {
        templatesLoader.get('register')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate());

                $('#btn-register').on('click', function (ev) {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };

                    data.register(user)
                        .then(function (respUser) {
                            data.login(respUser)
                                .then(function () {
                                    $('#login').addClass('logged-in');
                                    $('#register').addClass('logged-in');
                                    $('#logout').removeClass('logged-in');
                                    toastr.success("You've been successfully logged-in", "Login");
                                    window.location = "#/home";
                                });
                        }, function (err) {
                            toastr.error(err);
                        });


                    ev.preventDefault();
                    return false;
                });
            });
    }

    function login() {
        templatesLoader.get('login')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate());

                $('#btn-login').on('click', function (ev) {
                    var user = {
                        username: $('#tb-username').val(),
                        password: $('#tb-password').val()
                    };

                    data.login(user)
                        .then(function () {
                            $('#login').addClass('logged-in');
                            $('#register').addClass('logged-in');
                            $('#logout').removeClass('logged-in');
                            $('#cart').removeClass('logged-in');
                            $('.username').html(`Hello, ${user.username}!`);
                            toastr.success("You've been succssfully logged-in", "Login");
                            window.location = "#/home";
                        })
                        .catch(function (err) {
                            toastr.error(err.statusText, "Error");
                        });


                    ev.preventDefault();
                    return false;
                });
            });
    }

    function logout() {
        var user = {};
        data.logout(user);
    }

    function categories() {
        templatesLoader.get('categories')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate());
            });
    }

    function clothes() {
        templatesLoader.get('gallery')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);

                data.getCategory('Clothes')
                    .then(function (response) {
                        $('#template-holder').html(compiledTemplate(response));

                        $('#tb-filter').on('input', function () {
                            var itemsArrays = $('.item-name');
                            var searchWord = $('#tb-filter').val();
                            filterByName(itemsArrays, searchWord);
                        });
                    });
            });
    }

    function shoes() {
        templatesLoader.get('gallery')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);

                data.getCategory('Shoes')
                    .then(function (response) {
                        $('#template-holder').html(compiledTemplate(response));

                        $('#tb-filter').on('input', function () {
                            var itemsArrays = $('.item-name');
                            var searchWord = $('#tb-filter').val();
                            filterByName(itemsArrays, searchWord);
                        });
                    });
            });
    }

    function hats() {
        templatesLoader.get('gallery')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);

                data.getCategory('Hats')
                    .then(function (response) {
                        $('#template-holder').html(compiledTemplate(response));

                        $('#tb-filter').on('input', function () {
                            var itemsArrays = $('.item-name');
                            var searchWord = $('#tb-filter').val();
                            filterByName(itemsArrays, searchWord);
                        });
                    });
            });
    }

    function getCurrentItem(params, itemName) {
        var itemData;

        data.getSpecificItem(itemName, params.id)
            .then(function (response) {
                itemData = response;
                return templatesLoader.get('item');
            })
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate(itemData));

                $('#btn-add-item').on('click', function () {
                    data.addToCart(itemData, itemData._id, 'ShoppingCart')
                        .then(function () {
                            toastr.success('Added to cart', 'Shopping cart');
                        });
                });
            });
    }

    function getCurrentClothesItem(params) {
        getCurrentItem(params, 'Clothes')
    }

    function getCurrentShoesItem(params) {
        getCurrentItem(params, 'Shoes')
    }

    function getCurrentHatsItem(params) {
        getCurrentItem(params, 'Hats')
    }

    function showCart() {
        templatesLoader.get('shoppingCart')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);

                data.getCategory('ShoppingCart')
                    .then(function (response) {
                        var totalPrice = 0;
                        totalPrice = getSum(response);
                        if (!totalPrice) {
                            totalPrice = 0;
                        }

                        totalPrice = parseFloat(totalPrice.toString()).toFixed(2);

                        $('#template-holder').html(compiledTemplate(response));
                        $('#totalPrice').html('$' + totalPrice);

                        $('.btn-remove-item').on('click', function (ev) {
                            var $listElement = $(ev.target).parents('tr'),
                                itemId = $listElement.attr('data-id');

                            data.removeFromCart(itemId, 'ShoppingCart')
                                .then(function (items) {
                                    $listElement.remove();
                                });

                            showCart();
                        });

                        $('#btn-add-details').on('click', function (ev) {
                            window.location = "#/addDeliveryDetails";
                        });
                    });
            });
    }

    function addDeliveryDetails() {
        templatesLoader.get('addDeliveryDetails')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate);
            });
    }

    function orderAccepted() {
        templatesLoader.get('orderAccepted')
            .then(function (html) {
                var compiledTemplate = Handlebars.compile(html);
                $('#template-holder').html(compiledTemplate);
            });
    }

    return {
        home: home,
        register: register,
        login: login,
        logout: logout,
        categories: categories,
        clothes: clothes,
        shoes: shoes,
        hats: hats,
        getCurrentClothesItem: getCurrentClothesItem,
        getCurrentShoesItem: getCurrentShoesItem,
        getCurrentHatsItem: getCurrentHatsItem,
        showCart: showCart,
        addDeliveryDetails: addDeliveryDetails,
        orderAccepted: orderAccepted,
        map: map
    };
} ());
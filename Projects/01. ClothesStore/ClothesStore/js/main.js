var router = new Navigo(null, true);

router
    .on("home", controllers.home)
    .on("register", controllers.register)
    .on("login", controllers.login)
    .on("logout", controllers.logout)
    .on("contacts", controllers.map)
    .on("categories", controllers.categories)
    .on("clothes/", controllers.clothes)
    .on("clothes/:id", controllers.getCurrentClothesItem)
    .on("shoes", controllers.shoes)
    .on("shoes/:id", controllers.getCurrentShoesItem)
    .on("hats", controllers.hats)
    .on("hats/:id", controllers.getCurrentHatsItem)
    .on("shoppingCart", controllers.showCart)
    .on("addDeliveryDetails", controllers.addDeliveryDetails)
    .on("orderAccepted", controllers.orderAccepted)
    .on(() => {
        router.navigate("/home");
    })
    .resolve();

data.isLoggedIn()
    .then(function (isLoggedIn) {
        if (isLoggedIn) {
            $('#login').addClass('logged-in');
            $('#register').addClass('logged-in');
            $('#logout').removeClass('logged-in');
            $('#cart').removeClass('logged-in');
            $('#hello-username').addClass('logged-in');
        }
    });

$('#cart').on('click', function () {
    window.location = '#/shoppingCart';
});

$('.main-heading').on('click', function () {
    window.location = '#/home';
});

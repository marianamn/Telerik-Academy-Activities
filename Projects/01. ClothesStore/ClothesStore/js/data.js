/* globals data, requester, Promise */

const KEY_STORAGE_USERNAME = "username",
    KEY_STORAGE_AUTH_KEY = "authKey",
    APP_KEY = 'kid_ByJ1lcL6',
    APP_AUTH_KEY = btoa('kid_ByJ1lcL6:c45f12b54fee47b78dae28cf6b2008f8'),
    USERNAME_CHARS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890_.",
    USERNAME_MIN_LENGTH = 3,
    USERNAME_MAX_LENGTH = 30,
    PASSWORD_MIN_LENGTH = 6,
    PASSWORD_MAX_LENGTH = 20;

var data = (function () {

    function register(user) {
        var usernameError = validator.validateUsername(user.username, USERNAME_MIN_LENGTH, USERNAME_MAX_LENGTH, USERNAME_CHARS),
            passwordError = validator.validatePassword(user.password, PASSWORD_MIN_LENGTH, PASSWORD_MAX_LENGTH);

        if (usernameError) {
            return Promise.reject(usernameError.message);
        }

        if (passwordError) {
            return Promise.reject(passwordError.message);
        }

        var options = {
            headers: {
                'Authorization': 'Basic ' + APP_AUTH_KEY
            }
        };

        return requester.postJSON(`https://baas.kinvey.com/user/${APP_KEY}`, user, options);
    }

    function login(user) {
        var USER_AUTH_KEY = btoa(`${user.username}:${user.password}`);

        var options = {
            headers: {
                'Authorization': 'Basic ' + USER_AUTH_KEY
            }
        };

        return requester.postJSON(`https://baas.kinvey.com/user/${APP_KEY}/login`, user, options)
            .then(function (respUser) {
                localStorage.setItem(KEY_STORAGE_USERNAME, respUser.username);
                localStorage.setItem(KEY_STORAGE_AUTH_KEY, respUser._kmd.authtoken);
            });
    }

    function logout(user) {
        var authToken = localStorage.getItem(KEY_STORAGE_AUTH_KEY),
            options = {
                headers: {
                    'Authorization': 'Kinvey ' + authToken
                }
            };

        return requester.postJSON(`https://baas.kinvey.com/user/${APP_KEY}/_logout`, user, options)
            .then(function () {
                localStorage.removeItem(KEY_STORAGE_USERNAME);
                localStorage.removeItem(KEY_STORAGE_AUTH_KEY);
                $('#login').removeClass('logged-in');
                $('#register').removeClass('logged-in');
                $('#hello-username').removeClass('logged-in');
                $('.username').html('');
                $('#logout').addClass('logged-in');
                $('#cart').addClass('logged-in');
                toastr.success("You've been logged out", "Logout");
                window.location = '#/home';
            });
    }

    function isLoggedIn() {
        return Promise.resolve()
            .then(function () {
                return !!localStorage.getItem(KEY_STORAGE_USERNAME);
            });
    }

    function getCategory(name) {
        var url = `https://baas.kinvey.com/appdata/${APP_KEY}/${name}`,
            authToken = localStorage.getItem(KEY_STORAGE_AUTH_KEY),
            options = {
                headers: {
                    'Authorization': 'Kinvey ' + authToken
                }
            };

        return requester.getJSON(url, options);
    }

    function getSpecificItem(collectionName, itemId) {
        var url = `https://baas.kinvey.com/appdata/${APP_KEY}/${collectionName}/${itemId}`,
            authToken = localStorage.getItem(KEY_STORAGE_AUTH_KEY),
            options = {
                headers: {
                    'Authorization': 'Kinvey ' + authToken
                }
            };

        return requester.getJSON(url, options);
    }

    function addToCart(item, itemId, collectionName) {
        var url = `https://baas.kinvey.com/appdata/${APP_KEY}/${collectionName}/${itemId}`,
            authToken = localStorage.getItem(KEY_STORAGE_AUTH_KEY),
            options = {
                headers: {
                    'Authorization': 'Kinvey ' + authToken
                }
            };


        return requester.putJSON(url, item, options);
    }

    function removeFromCart(itemId, collectionName) {
        var url = `https://baas.kinvey.com/appdata/${APP_KEY}/${collectionName}/${itemId}`,
            authToken = localStorage.getItem(KEY_STORAGE_AUTH_KEY),
            options = {
                headers: {
                    'Authorization': 'Kinvey ' + authToken
                }
            };

        return requester.deleteJSON(url, options);
    }

    return {
        register: register,
        login: login,
        logout: logout,
        isLoggedIn: isLoggedIn,
        getCategory: getCategory,
        getSpecificItem: getSpecificItem,
        addToCart: addToCart,
        removeFromCart: removeFromCart
    };
} ());
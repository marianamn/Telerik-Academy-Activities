var requester = (function(){

    function get(url) {
        var promise = new Promise((resolve, reject) => {
            $.ajax({
                url,
                method: "GET",
                success: function(response) {
                    resolve(response);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    function putJSON(url, body, options = {}) {
        var promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};
            $.ajax({
                url,
                headers,
                method: "PUT",
                contentType: "application/json",
                data: JSON.stringify(body),
                success: function(response) {
                    resolve(response);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    function postJSON(url, body, options = {}) {
        var promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};

            $.ajax({
                url,
                headers,
                method: "POST",
                contentType: "application/json",
                data: JSON.stringify(body),
                success: function(response) {
                    resolve(response);
                },
                error: function(err) {
                    reject(err);
                }
            });
        });
        return promise;
    }

    function getJSON(url, options = {}) {
        var promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};

            $.ajax({
                url,
                headers,
                method: "GET",
                contentType: "application/json",
                success: function(response) {
                    resolve(response);
                },
                error: function(err) {
                    if(err.status === 401){
                        toastr.error("You have to be logged-in!");
                    }

                    reject(err);
                }
            });
        });

        return promise;
    }

    function deleteJSON(url, options = {}){
        var promise = new Promise((resolve, reject) => {
            var headers = options.headers || {};

            $.ajax({
                url,
                headers,
                method: "DELETE",
                contentType: "application/json",
                success: function(response){
                    resolve(response);
                },
                error: function(err){
                    reject(err);
                }
            });
        });

        return promise;
    }

    return {
        get: get,
        putJSON: putJSON,
        postJSON: postJSON,
        getJSON: getJSON,
        deleteJSON: deleteJSON
    };
}());
var templatesLoader = (function(){

    function get(templateName){
        var url = `templates/${templateName}.handlebars`;
        return requester.get(url);
    }

    return {
        get: get
    };
}());

const templateLoader =(() => {
    function get(templateName){
        const cache = {};

        return new Promise((resolve, reject) => {
            if (cache[templateName]) {
                resolve(cache[templateName]);
            } else{
                $.get(`/scripts/templates/${templateName}.handlebars`)
                    .done((data) => {
                        let compiledTemplate = Handlebars.compile(data);
                        cache[templateName] = compiledTemplate;
                        resolve(compiledTemplate);
                    })
                    .fail(reject);
            }
        })
    }

    return{
        get
    }
})();

export { templateLoader };

//{"result":{
//    "id":1001,
//    "title":"Thread 1",
//    "messages":[{
//        "username":"marianamn",
//        "content":"dkdkd",
//        "user":{"username":"marianamn"},
//        "postDate":"2016-09-25 12:26:51"}
//    ]}
//}

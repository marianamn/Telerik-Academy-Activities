import { data } from './data.js'
import { templateLoader } from './template-loader.js'

var router = (() => {
    let router;

    function init(){
        router = new Navigo(null, false);

        router
            .on('/threads/:id', (params) => {
                Promise.all([data.threads.getById(params.id), templateLoader.get('messages')])
                    .then(([data, template]) => $('#content').append(template(data)))
                    .catch(console.log);

                console.log(templateLoader.get('messages'))
            })
            .on('/threads', () =>{
                Promise.all([data.threads.get(), templateLoader.get('threads')])
                    .then(([data, template]) => $('#content').html(template(data)))
                    .catch(console.log)
            })
            .on('/gallery', () => {
                Promise.all([data.gallery.get(), templateLoader.get('gallery')])
                    .then(([data, template]) => $('#content').html(template(data)))
                    .catch(console.log)
            }).resolve();
    }

    return {
        init
    }
})();

export { router };
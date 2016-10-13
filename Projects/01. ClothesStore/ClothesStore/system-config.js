SystemJS.config({
    transpiler: 'plugin-babel',
    paths: {
        'npm:*': './node_modules/*',
        'bower:*': './bower_components/*',
    },
    map: {
        'plugin-babel': 'npm:/systemjs-plugin-babel/plugin-babel.js',
        'systemjs-babel-build': 'npm:/systemjs-plugin-babel/systemjs-babel-browser.js',
        'main': './js/main.js',
        'jquery': 'npm:/jquery/dist/jquery.js',
        'templatesLoader': './js/templatesLoader.js',
        'Handlebars': 'bower:/handlebars/handlebars.js',
        'clothesFactory': './js/models/clothes-factory.js'
    }
});
function print(item) {
    jsConsole.writeLine(item);
    console.log(item);
}

//Problem 1
function task1() {
    String.prototype.format = function (option) {
        var property,
            result = this;
        for (var property in option) {
            result = result.replace(new RegExp('#{' + property + '}','g'),option[property])
        }
        return result;
    }

    print('-------------------');
    print('Problem 1');
    print('-------------------');

    var options = { name: 'John' };
    var result = '\'Hello, there! Are you #{name}?\''.format(options);
    print(result);

    options = {name: 'John', age: 13};
    result = '\'My name is #{name} and I am #{age}-years-old\''.format(options);
    print(result);
}

//Problem 2
function task2() {
    String.prototype.bind = function (obj) {
        var property,
            reContent,
            reHref,
            reClass,
            result = this;

        for (property in obj) {
            reContent = new RegExp('(<.*data-bind-content="' + property + '".*>)(.*)(<.*>)', 'gi'),
                reHref = new RegExp('(<.*data-bind-href="' + property + '")', 'gi'),
                reClass = new RegExp('(data-bind-class="' + property + '")', 'gi');

            result = result.replace(reContent, function (none, opening, content, closing) {
                content = obj[property];
                return opening + content + closing;
            })
                .replace(reHref, function (none, content) {
                    return content + ' href="' + obj[property] + '"';
                })
                .replace(reClass, 'data-bind-class="' + obj[property] + '"');
        }
        return result;
    };

    print('-------------------');
    print('Problem 2');
    print('-------------------');

    var str = '<div data-bind-content="name"></div>';
    var result = str.bind({ name: 'Steven' });
    jsConsole.writeLine(result.replace(/</g, '&lt;'));
    console.log(result);

    var str2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>';
    var result2 = str2.bind({ name: 'Elena', link: 'http://telerikacademy.com' });
    jsConsole.writeLine(result2.replace(/</g, '&lt;'));
    console.log(result2);
}
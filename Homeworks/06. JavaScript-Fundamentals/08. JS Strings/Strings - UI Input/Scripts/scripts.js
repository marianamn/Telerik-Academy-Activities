function print(result) {
    jsConsole.writeLine(result);
    console.log(result);
}

//Problem 1
function task1() {
    var str = document.getElementById('problem1').value;
    var reversed = reversedString(str);
    print('Problem 1:\n<br/>' + reversed);

    function reversedString(string) {
        var result = '';
        for (var i = string.length-1; i >=0; i--) {
            result +=string[i];
        }

        return result;
    }
}

//Problem 2
function task2() {
    var expression= document.getElementById('problem2').value;
    if (firstCloseBrackets(expression) !== true && countBrackets(expression) === true) {
        print('Problem 2:\n<br/>' + 'Valid expression');
    }
    else {
        print('Problem 2:\n<br/>' + 'Invalid expression');
    }
    

    function firstCloseBrackets(string) {
        var result = false;
        if (string[1] === ')') {
            result = true;
        }

        return result;
    }

    function countBrackets(string) {
        var result = true;
        var count1 = 0;
        var count2 = 0;

        for (var i = 0; i < string.length; i++) {
            if (string[i] === ')') {
                count1 += 1;
            }
            else if (string[i] === '(') {
                count2 += 1;
            }
            else {
                continue;
            }
        }

        if (count1 !== count2) {
            result = false;
        }

        return result;
    }
}

//Problem 3
function task3() {
    var text = document.getElementById('problem3-a').value;
    var subStr = document.getElementById('problem3-b').value;
    print('Problem 3:\n<br/>' + countSubstringInText(text, subStr));


    function countSubstringInText(text, subStr) {
        var newtext = text.toLowerCase();
        var newSubStr = subStr.toLowerCase();
        var count = 0;

        for (var i = 0; i < (newtext.length - newSubStr.length) ; i++) {
            if (newtext.substr(i, newSubStr.length) === newSubStr) {
                count += 1;
            }
            else {
                continue;
            }
        }

        return count;
    }
}

//problem 4
function task4(){
    var text = document.getElementById('problem4').value;
    result = parseTags(text);
    print('Problem 4:\n<br/>' + result);

    function parseTags(text) {
        var i,
            jump,
            random,
            originalText = text,
            currentStateArr = [],
            newText = [],
            len = text.length;

        for (i = 0; i < text.length; i += 1) {
            if (text[i] === '<') {
                switch (text[i + 1]) {
                    case 'u':
                        currentStateArr.push('u');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case 'l':
                        currentStateArr.push('l');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case 'm':
                        currentStateArr.push('m');
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                    case '/':
                        currentStateArr.pop();
                        jump = text.indexOf('>', i);
                        i = jump + 1;
                        break;
                }
            }
            switch (currentStateArr[currentStateArr.length - 1]) {
                case undefined:
                    newText.push(text[i]);
                    break;
                case 'u':
                    newText.push(text[i].toUpperCase());
                    break;
                case 'l':
                    newText.push(text[i].toLowerCase());
                    break;
                case 'm':
                    random = Math.random();
                    if (random < 0.5) {
                        newText.push(text[i].toLowerCase());
                        break;
                    } else {
                        newText.push(text[i].toUpperCase());
                        break;
                    }
            }
        }
        return newText.join('');
    }
}

//problem 5
function task5() {
    var text = document.getElementById('problem5').value;
    result = replaseWhitespace(text);
    print('Problem 5:\n<br/>' + '\'' + result + '\'');

    function replaseWhitespace(text) {
        var result = text.split(' ').join('&nbsp;');

        return result;
    }
}

//problem 6
function task6() {
    var text = document.getElementById('problem6').value;
    result = textInTags(text);
    print('Problem 6:\n<br/>' + result);

    function textInTags(text) {
        var result = '';

        for (var i = 0; i < text.length; i++) {
            if (text[i] === '<') {
                i = text.indexOf('>', i);
            }
            if (text[i] !== '>') {
                result += text[i];
            }
        }
        return result;
    }
}

//Problem 7
function task7() {
    var input = document.getElementById('problem7').value;

    function Url(urlProtocol, urlServer, urlResource) {
        this.protocol = urlProtocol;
        this.server = urlServer;
        this.resource = urlResource;
        this.toString = function () {
            return 'protocol: ' + this.protocol + ', server: ' + this.server + ', resource: ' + this.resource;
        }
    }

    print('Problem 7:\n<br/>' + parseUrl(input));

    function parseUrl(url) {
        var protocole = url.substring(0, url.indexOf(':'));
        var currenntText = url.substr(protocole.length+3);
        var server = currenntText.substring(0, currenntText.indexOf('/'));
        var resource = currenntText.substr(server.length + 1);

        return new Url(protocole, server, resource);
    }
}

//Problem 8
function task8() {
    var input = document.getElementById('problem8').value;

    print('Problem 8:\n<br/>' + replaceTags(input));

    function replaceTags(text) {
        var resutedText1 = text.replace(/<a href="/g, '[URL=');
        var resutedText2 = resutedText1.replace(/">/g, ']');
        var resutedText3 = resutedText2.replace(/<\/a>/g, '[/URL]');

        return resutedText3;
    }
}

//Problem 9
function task9() {
    var text = document.getElementById('problem9').value;

    print('Problem 9:\n<br/>' + returnEmails(text));

    function returnEmails(text) {
        var words = text.split(' ');
        var result = [];

        for (var i = 0; i < words.length; i++) {
            if (words[i].indexOf("@") > 0) {

                if (words[i][words[i].length - 1] == '.') {

                    words[i] = words[i].substr(0, words[i].length - 1);
                }

                if (words[i].indexOf(".") > 0) {

                    if (words[i].indexOf('@') < words[i].indexOf('.')) {

                        result.push(words[i]);
                    }
                }
            }
        }

        return result.join(', ');
    }
}

//Problem 10
function task10() {
    var text = document.getElementById('problem10').value;

    print('Problem 10:\n<br/>' + findPalindrome(text));

    function findPalindrome(text) {
        var words = text.split(' ').map(function (item) {
            return item.trim('.,!?()"-');
        });

        var result = [];

        for (i = 0; i < words.length; i += 1) {
            if (words[i].length > 1 &&
                words[i].toLowerCase() === reverseWord(words[i].toLowerCase())) {
                result.push(words[i]);
            }
        }
        return result;
    }

    function reverseWord(word) {
        return word.split('').reverse().join('');
    }

    String.prototype.trimLeft = function (charlist) {
        if (charlist === undefined)
            charlist = "\s";

        return this.replace(new RegExp("^[" + charlist + "]+"), "");
    };

    String.prototype.trimRight = function (charlist) {
        if (charlist === undefined)
            charlist = "\s";

        return this.replace(new RegExp("[" + charlist + "]+$"), "");
    };

    String.prototype.trim = function (charlist) {
        return this.trimLeft(charlist).trimRight(charlist);
    };
}

//Problem 11
function task11() {
    var result,
        str1 = format('{0}, {1}!', 'Hello', 'World'),
        str2 = format("{0}, {1}, {0} text {2}", 1, "Pesho", "Gosho"),
        str3 = format("Array: {0}, Object: {1}, Boolean: {2}", [1, 2, 3], {
            a: 1,
            b: 2,
            toString : function(){
                return this.a + ' ' + this.b;
        }
        }, true);

    result = 'Ex.1: ' + str1 + '<br />' +
        'Ex.2: ' + str2 + '<br />' +
        'Ex.3: ' + str3;

    print('Problem 11:\n<br/>Ex.1: ' + str1 + '\n<br/>Ex.2: ' + str2 + '\n<br/>Ex.3: ' + str3);



    function format(str) {
        var newArguments = arguments;
        return str.replace(/{(\d+)}/g, function (match, p1) {
            return newArguments[+p1 + 1];
        });
    }

}

//Problem 12
function task12() {
    var people = [{ name: 'Peter', age: 14 },
                  { name: 'Ivan', age: 18 },
                  { name: 'Maria', age: 19 }],
    template = '<strong>-{name}-</strong> <span>-{age}-</span>';

    print('Problem 12:\n<br/>' + generateList(people, template));


    function generateList(people, template) {
        var result = '',
            placeholder;

        result += '<ul>';

        for (var i = 0; i < people.length; i += 1) {
            result += '<li>';

            var currentListItem = template.replace('-{name}-', people[i].name);
            currentListItem = currentListItem.replace('-{age}-', people[i].age);

            result += currentListItem;
            result += '</li>';
        }
        result += '</ul>';
        return result;
    }

}
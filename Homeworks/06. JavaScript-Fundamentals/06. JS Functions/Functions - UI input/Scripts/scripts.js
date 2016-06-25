function print(result) {
    jsConsole.writeLine(result);
    console.log(result);
}

//Problem 1
function task1() {
    var number = document.getElementById('problem1').value;
    var digit = number % 10;
    lastDigit(digit);


    function lastDigit(param) {
        var result;
        switch (param) {
            case 0: result = 'zero'; break;
            case 1: result = 'one'; break;
            case 2: result = 'two'; break;
            case 3: result = 'three'; break;
            case 4: result = 'four'; break;
            case 5: result = 'five'; break;
            case 6: result = 'six'; break;
            case 7: result = 'seven'; break;
            case 8: result = 'eight'; break;
            case 9: result = 'nine'; break;
            default: result = 'wrong input number'; break;
        }
        print(result);
    }
}

//Problem 2
function task2() {
    var number = document.getElementById('problem2').value;
    reverseNumber(number);

    function reverseNumber(num) {
        var reversed = "";
        var temp = 0;

        if (num < 0) {
            temp = (-num).toString();
        }
        else {
            temp = num;
        }

        var len = temp.toString().length - 1;

        for (var i = len; i >= 0; i-=1) {
            reversed = reversed + temp[i];
        }


        if (num < 0) {
            print('-' + reversed);
        }
        else {
            print(reversed);
        }
    }
}

//Problem 3
function task3() {
    var text = document.getElementById('problem3-a').value;
    var replacePunctuation = text.replace(/\W+/g, ' ');
    var words = replacePunctuation.split(' ');
    var word = document.getElementById('problem3-b').value;

    var casing = 'insensitive';
    print('Case sensitive: count=' + countWordOccurrence(words, word));
    print('Case insensitive: count=' + countWordOccurrence(words, word, casing));


    function countWordOccurrence(words, word, casing) {
        var count = 0;
        if (casing === 'insensitive') {
            for (var i = 0; i < words.length; i++) {
                if (words[i].toString().toLowerCase() == word.toString().toLowerCase()) {
                    count++;
                }
            }
        }
        else {
            for (var i = 0; i < words.length; i++) {
                if (words[i] == word) {
                    count++;
                }
            }
        }
        return count;
    }
}

//Problem 4
function task4() {
    getDivs();

    function getDivs() {
        print("Number of Div tags in current html document: " + document.getElementsByTagName('div').length);
    }
}


//Problem 5
function task5() {
    var input = document.getElementById('problem5-a').value;
    var array = input.split(", ");
    var number = document.getElementById('problem5-b').value;

    countNumber(array, number);

    function countNumber(array, number) {
        var count = 0;
        for (var i = 0; i < array.length; i++) {
            if (array[i] === number) {
                count += 1;
            }
        }

        if (count === 0) {
            print('Number you have entered does not exist in array.');
        }
        else {
            print(count);
        }
    }
}

//Problem 6
function task6() {
    var input = document.getElementById('problem6-a').value;
    var array = input.split(", ");
    var position = document.getElementById('problem6-b').value;
    largerThanNeighbours(array, position);

    function largerThanNeighbours(array, pos) {
        var result;


        for (var i = 0; i < array.length; i++) {
            if (pos < 1 || pos > (array.length - 1)) {
                result='Number of this position does not have two neighbours';
                break;
            }
            else {
                if (i == pos) {
                    if (array[i - 1] < array[i] && array[i] > array[i + 1]) {
                        result = true;
                    }
                    else {
                        result = false;
                        break;
                    }
                }
            }
        }

        print(result);
    }
}


//Problem 7
function task7() {
    var input = document.getElementById('problem7').value;
    var array = input.split(", ");
    largerThanNeighbours(array);

    function largerThanNeighbours(array) {
        var result;

        for (var i = 0; i < array.length; i++) {
            if (array[i - 1] < array[i] && array[i] > array[i + 1]) {
                result = array[i];
                break;
            }
            else {
                result = -1;
            }
        }

        print(result);
    }
}

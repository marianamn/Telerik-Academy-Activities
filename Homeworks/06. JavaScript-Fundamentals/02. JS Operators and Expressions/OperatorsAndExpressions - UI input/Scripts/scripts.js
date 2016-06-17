//Problem 1
function task1() {
    var n = document.getElementById('problem1').value;
    var isNumberOdd;

    if((n % 2) != 0){
        isNumberOdd = true;
    }
    else{
        isNumberOdd = false
    }

    jsConsole.writeLine('n='+ n);
    jsConsole.writeLine('Is number Odd? - '+ isNumberOdd);

    console.log('n='+ n);
    console.log('Is number Odd? - ', isNumberOdd);
}

//Problem 2
function task2() {
    var Dividable
    var n = document.getElementById('problem2').value;
    var isNumberDividableBy7 = (n % 7) === 0;
    var isNumberDividableBy5 = (n % 5) === 0;
    var numberDividableBy7And5 = isNumberDividableBy7 && isNumberDividableBy5;

    jsConsole.writeLine('n=' + n);
    jsConsole.writeLine('Is number Dividable by 7 and 5? - ' + numberDividableBy7And5);

    console.log('n=' + n);
    console.log('Is number Dividable by 7 and 5? - ', numberDividableBy7And5);
}

//Problem 3
function task3() {
    var width = document.getElementById('problem3-width').value;
    var height = document.getElementById('problem3-height').value;
    var area = width * height;

    jsConsole.writeLine('width=' + width);
    jsConsole.writeLine('height=' + height);
    jsConsole.writeLine('area=' + area);

    console.log('width=' + width);
    console.log('height=' + height);
    console.log('area=' + area);
}

//Problem 4
function task4() {
    var n = document.getElementById('problem4').value;
    var isThirdDigitSeven = (Math.floor(n / 100) % 10 === 7);

    jsConsole.writeLine('n=' + n);
    jsConsole.writeLine('Third Digit Seven? - ' + isThirdDigitSeven);

    console.log('n=' + n);
    console.log('Third Digit Seven? - ', isThirdDigitSeven);
}

//Problem 5
function task5() {
    var n = document.getElementById('problem5').value;
    var binary = parseInt(n, 10).toString(2);
    var pad = '0000000000000000';
    var binaryNumber = (pad + binary).slice(-pad.length);
    var thirdBit = (n >> 3)& 1;

    jsConsole.writeLine('n=' + n);
    jsConsole.writeLine('binary representation=' + binaryNumber);
    jsConsole.writeLine('third bit=' + thirdBit);

    console.log('n=' + n);
    console.log('binary representation=' + binaryNumber);
    console.log('third bit=' + thirdBit);
}

//Problem 6
function task6() {
    var x = document.getElementById('problem6-x').value;
    var y = document.getElementById('problem6-y').value;

    var circleX = 0,
        circleY = 0,
        circleRadius = 5;

    var isInCircle = ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY)) <= circleRadius * circleRadius;

    jsConsole.writeLine('Point coordinates {' + x + ', ' + y + '}');
    jsConsole.writeLine('Circle coordinates K({0, 0}, 5)');
    jsConsole.writeLine('Is point inside a circle? - ' + isInCircle);

    console.log('Point {' + x + ', ' + y + '}');
    console.log('Circle coordinates K({0, 0}, 5)');
    console.log('Is point inside a circle? - ' + isInCircle);
}

//Problem 7
function task7() {
    var n = document.getElementById('problem7').value;
    var isPrime = true;

    if (n > 1) {
        for (var i = 2; i < n ; i++) {
            if ((n % i) === 0) {
                isPrime = false;
                break;
            }
        }
    }
    else {
        isPrime = false;
    }
    
    jsConsole.writeLine('n=' + n);
    jsConsole.writeLine('Is number prime? - ' + isPrime);

    console.log('n=' + n);
    console.log('Is number prime? - ' + isPrime);
}

//Problem 8
function task8() {
    var a = document.getElementById('problem8-a').value;
    var b = document.getElementById('problem8-b').value;
    var h = document.getElementById('problem8-h').value;

    var area = ((a * 1 + b * 1) / 2) * (h * 1);

    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('h=' + h);
    jsConsole.writeLine('area=' + area);

    console.log('a=' + a);
    console.log('b=' + b);
    console.log('h=' + h);
    console.log('area=', + area);
}

//Problem 9
//circle K( (1,1), 3) 
//rectangle R(top=1, left=-1, width=6, height=2)
function task9() {
    var x = document.getElementById('problem9-x').value;
    var y = document.getElementById('problem9-y').value;

    var circleX = 1,
        circleY = 1,
        circleRadius = 3;

    var isInCircle = ((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY)) <= circleRadius * circleRadius;
    var isInRectangle = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
    var isPointInCircleAndOutRectangle = isInCircle && isInRectangle;

    if (isPointInCircleAndOutRectangle === true) {
        jsConsole.writeLine('Point coordinates {' + x + ', ' + y + '}');
        jsConsole.writeLine('Is point inside a circle and outside rectangle? - yes');

        console.log('Point {' + x + ', ' + y + '}');
        console.log('Is point inside a circle and outside rectangle? - yes');
    }
    else {
        jsConsole.writeLine('Point coordinates {' + x + ', ' + y + '}');
        jsConsole.writeLine('Is point inside a circle and outside rectangle? - no');

        console.log('Point {' + x + ', ' + y + '}');
        console.log('Is point inside a circle and outside rectangle? - no');
    }

}
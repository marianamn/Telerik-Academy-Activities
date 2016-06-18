//Problem 1
function task1() {
    var b =  parseFloat(document.getElementById('problem1-b').value);
    var a =  parseFloat(document.getElementById('problem1-a').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    console.log('a=' + a);
    console.log('b=' + b);

    if (a > b) {
        jsConsole.writeLine('result: ' + b + ' ' + a);
        console.log('result: ' + b + ' ' + a);
    }
    else {
        jsConsole.writeLine('result: ' + a + ' ' + b);
        console.log('result: ' + a + ' ' + b);
    }
}

//Problem 2
function task2() {
    var a =  parseFloat(document.getElementById('problem2-a').value);
    var b =  parseFloat(document.getElementById('problem2-b').value);
    var c =  parseFloat(document.getElementById('problem2-c').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('c=' + c);
    console.log('a=' + a);
    console.log('b=' + b);
    console.log('c=' + c);

    if ((a == 0 || b == 0 || c == 0)) {
        jsConsole.writeLine('result: 0');
        console.log('result: 0');
    }
    else if ((a < 0 && b < 0 && c < 0) || (a > 0 && b > 0 && c < 0) || (a > 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c > 0)) {
        jsConsole.writeLine('result: -');
        console.log('result: -');
    }
    else {
        jsConsole.writeLine('result: +');
        console.log('result: +');
    }
}


//Problem 3
function task3() {
    var a =  parseFloat(document.getElementById('problem3-a').value);
    var b =  parseFloat(document.getElementById('problem3-b').value);
    var c =  parseFloat(document.getElementById('problem3-c').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('c=' + c);
    console.log('a=' + a);
    console.log('b=' + b);
    console.log('c=' + c);

    if (a > b && a > c) {
        jsConsole.writeLine('biggest=' + a);
        console.log('biggest=' + a);
    }
    else {
        if (b > a && b > c) {
            jsConsole.writeLine('biggest=' + b);
            console.log('biggest=' + b);
        }
        else {
            jsConsole.writeLine('biggest=' + c);
            console.log('biggest=' + c);
        }
    }
}


//Problem 4
function task4() {
    var a = parseFloat(document.getElementById('problem4-a').value);
    var b = parseFloat(document.getElementById('problem4-b').value);
    var c = parseFloat(document.getElementById('problem4-c').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('c=' + c);
    console.log('a=' + a);
    console.log('b=' + b);
    console.log('c=' + c);

    if (a > b && a > c && b > c) {
        jsConsole.writeLine('sorted: ' + a +' ' + b +' ' + c);
        console.log('sorted: ' + a + ' ' + b + ' ' + c);
    }
    else {
        if (b > a && b > c && a > c) {
            jsConsole.writeLine('sorted: ' + b + ' ' + a + ' ' + c);
            console.log('sorted: ' + b + ' ' + a + ' ' + c);
        }
        else {
            if (c > a && c > b && a > b) {
                jsConsole.writeLine('sorted: ' + c + ' ' + a + ' ' + b);
                console.log('sorted: ' + c + ' ' + a + ' ' + b);
            }
            else {
                if (a > b && a > c && c > b) {
                    jsConsole.writeLine('sorted: ' + a + ' ' + c + ' ' + b);
                    console.log('sorted: ' + a + ' ' + c + ' ' + b);
                }
                else {
                    if (b > a && b > c && c > a) {
                        jsConsole.writeLine('sorted: ' + b + ' ' + c + ' ' + a);
                        console.log('sorted: ' + b + ' ' + c + ' ' + a);
                    }
                    else {
                        jsConsole.writeLine('sorted: ' + c + ' ' + b + ' ' + a);
                        console.log('sorted: ' + c + ' ' + b + ' ' + a);
                    }
                }
            }
        }
    }
}


//Problem 5
function task5() {
    var n = parseFloat(document.getElementById('problem5').value);  
    jsConsole.writeLine('n=' + n);
    console.log('n=' + n);
    switch (n) {
        case 0:
            jsConsole.writeLine('Zero');
            console.log('Zero');
            break;
        case 1:
            jsConsole.writeLine('One');
            console.log('One');
            break;
        case 2:
            jsConsole.writeLine('Two');
            console.log('Two');
            break;
        case 3:
            jsConsole.writeLine('Three');
            console.log('Three');
            break;
        case 4:
            jsConsole.writeLine('Four');
            console.log('Four');
            break;
        case 5:
            jsConsole.writeLine('Five');
            console.log('Five');
            break;
        case 6:
            jsConsole.writeLine('Six');
            console.log('Six');
            break;
        case 7:
            jsConsole.writeLine('Seven');
            console.log('Seven');
            break;
        case 8:
            jsConsole.writeLine('Eight');
            console.log('Eight');
            break;
        case 9:
            jsConsole.writeLine('Nine');
            console.log('Nine');
            break;
        default:
            jsConsole.writeLine('not a digit');
            console.log('not a digit');
            break;
    }
}


//Problem 6
function task6() {
    var a = parseFloat(document.getElementById('problem6-a').value);
    var b = parseFloat(document.getElementById('problem6-b').value);
    var c = parseFloat(document.getElementById('problem6-c').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('c=' + c);
    console.log('a=' + a);
    console.log('b=' + b);
    console.log('c=' + c);

    var x1 = (-b - (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);
    var x2 = (-b + (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);

    if ((Math.pow(b, 2) - 4 * a * c) < 0){
        jsConsole.writeLine('no real roots');
        console.log('no real roots');
    }
    else{
        if ((Math.pow(b, 2) - 4 * a * c) === 0){
            jsConsole.writeLine('x1=x2='+ x1);
            console.log('x1=x2='+ x1);
        }
        else{
            jsConsole.writeLine('x1=' + x1 + '; x2='+ x2);
            console.log('x1=' + x1 + '; x2='+ x2);
        }
    }
}

//Problem 7
function task7() {
    var a = parseFloat(document.getElementById('problem7-a').value);
    var b = parseFloat(document.getElementById('problem7-b').value);
    var c = parseFloat(document.getElementById('problem7-c').value);
    var d = parseFloat(document.getElementById('problem7-d').value);
    var e = parseFloat(document.getElementById('problem7-e').value);
    jsConsole.writeLine('a=' + a);
    jsConsole.writeLine('b=' + b);
    jsConsole.writeLine('c=' + c);
    jsConsole.writeLine('d=' + d);
    jsConsole.writeLine('e=' + e);
    console.log('a=' + a);
    console.log('b=' + b);
    console.log('c=' + c);
    console.log('d=' + d);
    console.log('e=' + e);

    if (a > b && a > c && a > d && a > e) {
        jsConsole.writeLine('result=' + a);
        console.log('result=' + a);
    }
    else {
        if (b > a && b > c && b > d && b > e) {
            jsConsole.writeLine('result=' + b);
            console.log('result=' + b);
        }
        else {
            if (c > a && c > b && c > d && c > e) {
                jsConsole.writeLine('result=' + c);
                console.log('result=' + c);
            }
            else {
                if (d > a && d > b && d > c && d > e) {
                    jsConsole.writeLine('result=' + d);
                    console.log('result=' + d);
                }
                else {
                    jsConsole.writeLine('result=' + e);
                    console.log('result=' + e);
                }
            }
        }
    }
}

//Problem 8
function task8() {
    var n = parseFloat(document.getElementById('problem8').value);
    jsConsole.writeLine('n=' + n);
    console.log('n=' + n);

    var digits =Math.floor(n % 10);
    var tens = Math.floor((n / 10) % 10);
    var special = 10 + digits;
    var hundreds = Math.floor(n / 100);

    var digitsText;
    var tensText;
    var specialText; 
    var hundredsText; 
    
    switch (digits) {
        case 1: digitsText = 'one'; break;
        case 2: digitsText = 'two'; break;
        case 3: digitsText = 'three'; break;
        case 4: digitsText = 'four'; break;
        case 5: digitsText = 'five'; break;
        case 6: digitsText = 'six'; break;
        case 7: digitsText = 'seven'; break;
        case 8: digitsText = 'eight'; break;
        case 9: digitsText = 'nine'; break;
        default: digitsText = ''; break;
    }

    switch (tens) {
        case 1: tensText = 'ten '; break;
        case 2: tensText = 'twenty '; break;
        case 3: tensText = 'thirty '; break;
        case 4: tensText = 'fourty '; break;
        case 5: tensText = 'fifty '; break;
        case 6: tensText = 'sixty '; break;
        case 7: tensText = 'seventy '; break;
        case 8: tensText = 'eighty '; break;
        case 9: tensText = 'ninety '; break;
        default: tensText = ''; break;
    }

    switch (special) {
        case 11: specialText = 'eleven'; break;
        case 12: specialText = 'twelve'; break;
        case 13: specialText = 'thirteen'; break;
        case 14: specialText = 'fourteen'; break;
        case 15: specialText = 'fifteen'; break;
        case 16: specialText = 'sixteen'; break;
        case 17: specialText = 'seventeen'; break;
        case 18: specialText = 'eighteen'; break;
        case 19: specialText = 'nineteen'; break;
        default: specialText = ''; break;
    }

    switch (hundreds) {
        case 1: hundredsText = 'one hundred '; break;
        case 2: hundredsText = 'two hundred '; break;
        case 3: hundredsText = 'three hundred '; break;
        case 4: hundredsText = 'four hundred '; break;
        case 5: hundredsText = 'five hundred '; break;
        case 6: hundredsText = 'six hundred '; break;
        case 7: hundredsText = 'seven hundred '; break;
        case 8: hundredsText = 'eight hundred '; break;
        case 9: hundredsText = 'nine hundred '; break;
        default: hundredsText = ''; break;
    }

    if (hundreds != 0 && n >= 10 && digits!=0) {
        hundredsText = hundredsText + "and ";
    }

    if (tens == 1 && digits > 0) {
        jsConsole.writeLine((hundredsText + specialText).charAt(0).toUpperCase() + (hundredsText + specialText).slice(1));
        console.log((hundredsText + specialText).charAt(0).toUpperCase() + (hundredsText + specialText).slice(1));
        hundredsText = "";
        tensText = "";
    }
    else if (n == 0) {
        jsConsole.writeLine('zero'.charAt(0).toUpperCase() + 'zero'.slice(1));
        console.log('zero'.charAt(0).toUpperCase() + 'zero'.slice(1));
    }
    else {
        jsConsole.writeLine((hundredsText + tensText + digitsText).charAt(0).toUpperCase() + (hundredsText + tensText + digitsText).slice(1));
        console.log((hundredsText  + tensText + digitsText).charAt(0).toUpperCase() + (hundredsText +  tensText + digitsText).slice(1));
    }
}
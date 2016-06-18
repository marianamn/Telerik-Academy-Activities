function solve(args){
    var n = +args[0],
        digits,
        tens,
        special,
        hundreds,
        digitsText,
        tensText,
        specialText,
        hundredsText;

    digits = Math.floor(n % 10);
    tens = Math.floor((n / 10) % 10);
    special = 10 + digits;
    hundreds = Math.floor(n / 100);

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
        case 4: tensText = 'forty '; break;
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
        console.log((hundredsText + specialText).charAt(0).toUpperCase() + (hundredsText + specialText).slice(1));
        hundredsText = "";
        tensText = "";
    }
    else if (n == 0) {
        console.log('zero'.charAt(0).toUpperCase() + 'zero'.slice(1));
    }
    else {
        console.log((hundredsText  + tensText + digitsText).charAt(0).toUpperCase() + (hundredsText +  tensText + digitsText).slice(1));
    }
}

solve(['999']);

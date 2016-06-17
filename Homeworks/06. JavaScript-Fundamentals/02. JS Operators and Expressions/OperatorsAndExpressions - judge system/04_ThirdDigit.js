/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var number = +args[0],
        thirdDigit = 0;

    thirdDigit = Math.floor(number / 100) % 10;

    if(thirdDigit === 7){
        console.log('true')
    }else{
        console.log('false ' + thirdDigit)
    }
}

solve(['5']);
solve(['701']);
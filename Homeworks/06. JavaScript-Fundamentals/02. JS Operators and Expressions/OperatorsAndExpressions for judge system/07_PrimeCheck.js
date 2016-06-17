/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var number = +args[0],
        isPrime;

    if (number > 1) {
        for (var i = 2; i < number ; i++) {
            if ((number % i) === 0) {
                isPrime = false;
                break;
            }else{
                isPrime = true;
            }
        }
    }
    else {
        isPrime = false;
    }

    console.log(isPrime);
}

solve(['23']);
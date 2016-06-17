/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var number = +args[0];

    if((number % 7) === 0 && (number % 5) === 0){
        console.log('true ' + number)
    }else{
        console.log('false ' + number)
    }
}

solve(['35']);
/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var number = +args[0];

    if((number % 2) === 0){
        console.log('even ' + number);
    }else{
        console.log('odd ' + number);
    }
}

//solve(['3']);
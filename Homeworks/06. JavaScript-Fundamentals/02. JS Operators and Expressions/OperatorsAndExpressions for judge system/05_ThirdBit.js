/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var number = +args[0],
        binary = number.toString(2),
        pad = '0000000000000000',
        binaryNumber = (pad + binary).slice(-pad.length),
        thirdBit = (number >> 3)& 1;

    console.log(thirdBit)
}

solve(['15']);
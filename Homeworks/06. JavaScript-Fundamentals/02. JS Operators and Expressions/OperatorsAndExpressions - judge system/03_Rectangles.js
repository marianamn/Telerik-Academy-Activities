/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var width = +args[0],
        height = +args[1],
        area = 0,
        parameter;

    area = width*height;
    parameter = 2 *(width + height);

    console.log(Number(area).toFixed(2) + ' ' + Number(parameter).toFixed(2));
}

solve(['2.5', '3']);
/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var a = 0,
        b = 0,
        h = 0,
        area = 0;

    a = +args[0];
    b = +args[1];
    h = +args[2];

    area = ((a + b)) / 2 * h;
    console.log(Number(area).toFixed(7));
}

solve(['5','7','12']);
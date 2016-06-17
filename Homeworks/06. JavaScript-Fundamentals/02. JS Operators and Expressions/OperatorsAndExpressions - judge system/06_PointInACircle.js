/**
 * Created by Mariyana on 17.6.2016 г..
 */

function solve(args) {
    var x = +args[0],
        y = +args[1],
        centerX = 0,
        centerY = 0,
        radius = 2,
        result = 0,
        distance = 0;

    //(x - center_x)^2 + (y - center_y)^2 < radius^2
    result = Math.pow((x - centerX), 2) + Math.pow((y - centerY), 2);
    distance = Math.sqrt(result);

    if(result <= Math.pow(radius, 2)){
        console.log('yes ' + Number(distance).toFixed(2))
    }else{
        console.log('no ' + Number(distance).toFixed(2))
    }
}

solve(['2.5', '2']);
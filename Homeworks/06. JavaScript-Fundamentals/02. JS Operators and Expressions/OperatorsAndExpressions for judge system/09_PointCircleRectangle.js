/**
 * Created by Mariyana on 17.6.2016 г..
 */

//K({1, 1}, 1.5)
//R(top=1, left=-1, width=6, height=2)
function solve(args) {
    var x = +args[0],
        y = +args[1],
        circleX = 1,
        circleY = 1,
        radius = 1.5,
        top = 1,
        left = -1,
        width = 6,
        height = 2,
        isInCircle,
        outsideRectangle,
        result = "";

    isInCircle = Math.pow((x - circleX), 2) + Math.pow((y - circleY), 2) <= Math.pow(radius, 2);
    outsideRectangle = ((x < -1) || (x > 5) || (y > 1) || (y < -1));

    if(isInCircle){
        result += 'inside circle ';
    }else{
        result += 'outside circle ';
    }

    if(!outsideRectangle){
        result += 'inside rectangle';
    }else{
        result += 'outside rectangle';
    }

    console.log(result)
}

solve(['2.5', '2']);
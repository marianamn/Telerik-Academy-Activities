function solve(args){
    var pointAx = +args[0],
        pointAy = +args[1],
        pointBx = +args[2],
        pointBy = +args[3],

        pointCx = +args[4],
        pointCy = +args[5],
        pointDx = +args[6],
        pointDy = +args[7],

        pointEx = +args[8],
        pointEy = +args[9],
        pointFx = +args[10],
        pointFy = +args[11],

        pointA,
        pointB,
        pointC,
        pointD,
        pointE,
        pointF,

        firstLine,
        secondLine,
        thirdLine,
        canThreeLinesFormTriangle;

    pointA = new point(pointAx, pointAy);
    pointB = new point(pointBx, pointBy);
    pointC = new point(pointCx, pointCy);
    pointD = new point(pointDx, pointDy);
    pointE = new point(pointEx, pointEy);
    pointF = new point(pointFx, pointFy);

    firstLine =  distanceBetweenPoints(pointA, pointB);
    secondLine =  distanceBetweenPoints(pointC, pointD);
    thirdLine =  distanceBetweenPoints(pointE, pointF);
    canThreeLinesFormTriangle = canFormTriangle(firstLine, secondLine, thirdLine);

    console.log(firstLine.toFixed(2));
    console.log(secondLine.toFixed(2));
    console.log(thirdLine.toFixed(2));

    if(canThreeLinesFormTriangle){
        console.log('Triangle can be built')
    }
    else{
        console.log('Triangle can not be built')
    }

    function point(x, y){
        return {
            x: x,
            y: y
        }
    }

    function line(startPoint, endPoint){
        return {
            start: startPoint,
            end: endPoint
        }
    }

    function distanceBetweenPoints(point1, point2) {
        var distance = Math.sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));

        return distance;
    }

    function canFormTriangle(a, b, c) {
        var canThreeLinesFormTriangle;

        if ((a + b) > c && (a + c) > b && (c + b) > a) {
            canThreeLinesFormTriangle = true;
        }
        else {
            canThreeLinesFormTriangle = false;
        }

        return canThreeLinesFormTriangle;
    }
}

solve([ '5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12' ]);

solve([ '7', '7', '2', '2', '5', '6', '2', '2', '95', '-14.5', '0', '-0.123' ]);

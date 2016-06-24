function solve(args){
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        x1,
        x2;

    x1 = (-b + (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);
    x2 = (-b - (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);

    if ((Math.pow(b, 2) - 4 * a * c) < 0 || a === 0){
        console.log('no real roots');
    }
    else{
        if ((Math.pow(b, 2) - 4 * a * c) === 0){
            console.log('x1=x2=' + Number(x1).toFixed(2));
        }
        else if(x1 < x2){
            console.log('x1=' + Number(x1).toFixed(2) + '; ' + 'x2=' + Number(x2).toFixed(2));
        }
        else{
            console.log('x1=' + Number(x2).toFixed(2) + '; ' + 'x2=' + Number(x1).toFixed(2));
        }
    }
}

solve(['2', '5', '-3']);

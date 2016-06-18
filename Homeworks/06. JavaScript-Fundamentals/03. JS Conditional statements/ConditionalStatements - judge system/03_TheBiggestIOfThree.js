function solve(args){
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        max;

    if (a >= b){
        if(a >= c) {
            max = a;
        }else{
            max = c;
        }
    }else{
        if(b >= c)
        {
            max = b;
        }else{
            max = c;
        }
    }

    console.log(max);
}

solve(['-2', '-2', '-0']);
function solve(args){
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a >= b){
        if(a >= c) {
            if(b >= c){
                console.log(a + ' ' + b + ' ' + c);
            }
            else{
                console.log(a + ' ' + c + ' ' + b);
            }
        }
        else if(a <= b){
            console.log(c + ' ' + b + ' ' + a);
        }
        else{
            console.log(c + ' ' + a + ' ' + b);
        }
    }else{
        if(b >= c)
        {
            if(a <= c){
                console.log(b + ' ' + c + ' ' + a);
            }
            else{
                console.log(b + ' ' + a + ' ' + c);
            }
        }else{
            if(a <= b){
                console.log(c + ' ' + b + ' ' + a);
            }
            else{
                console.log(c + ' ' + a + ' ' + b);
            }
        }
    }
}

solve(['-2', '2', '0']);

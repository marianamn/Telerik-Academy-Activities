function solve(args){
    var a = parseInt(args[0]),
        b = parseInt(args[1]);

    if(a > b){
        console.log(b + ' ' + a);
    }else{
        console.log(a + ' ' + b)
    }
}

solve(['5', '2']);

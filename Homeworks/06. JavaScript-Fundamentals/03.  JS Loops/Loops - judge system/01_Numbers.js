function solve(args){
    var number = +args[0],
        i,
        result = 1;

    for(i = 2; i<= number; i++){
        result += ' ' + i;
    }

    console.log(result);
}

solve(['1']);
function solve(args){
    var numbers = args[0].split(' ').map(Number),
        a = numbers[0],
        b = numbers[1],
        c = numbers[2],
        max;

    function getMax(a, b){
        if(a > b){
            return a;
        }
        else{
            return b;
        }
    }

    max = Math.max(getMax(a,b), getMax(b, c));
    console.log(max);
}

solve(['8 3 6'])
solve(['7 19 19'])

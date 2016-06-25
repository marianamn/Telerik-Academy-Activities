function solve(args){
    var arr = args[0].split('\n'),
        firstCharArray = arr[0],
        secondCharArray = arr[1];

    if (firstCharArray > secondCharArray){
        console.log(">");
    }
    else if (firstCharArray < secondCharArray){
        console.log("<");
    }
    else{
        console.log("=");
    }
}

console.log("Task 2");
solve(['hello\nhalo']);
solve(['food\nfood']);
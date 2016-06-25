function solve(args){
    var n = +args[0],
        arr = [],
        i,
        j;
    
    for(i = 0; i < n; i++){
        arr[i] = i * 5;
    }
    
    for(j = 0; j < arr.length; j++){
        console.log(arr[j]);
    }
}

console.log("Task 1");
solve(['5']);
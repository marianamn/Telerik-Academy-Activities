function solve(args){
    var arr = (args + '').split('\n').map(Number),
        n = arr[0],
        numbers = [],
        i,
        maxCount = 1,
        currentCount = 1;

    //console.log(arr);

    for(i = 1; i <= n; i++){
        numbers[i-1]= +arr[i];
    }

    //console.log(numbers);

    for(i = 1; i < n; i++){
        if(numbers[i-1] === numbers[i]){
            ++currentCount;
        }
        else{
            currentCount = 1;
        }

        if(currentCount > maxCount){
            maxCount = currentCount;
        }
    }

    console.log(maxCount);
}

console.log("Task 3");
solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);

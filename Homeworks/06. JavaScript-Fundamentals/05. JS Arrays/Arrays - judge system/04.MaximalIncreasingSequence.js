function solve(args){
    var arr = (args + '').split('\n').map(Number),
        n = arr[0],
        numbers = [],
        i,
        maxCount = 1,
        increasingSequence = 0;

    //console.log(arr);

    for(i = 1; i <= n; i++){
        numbers[i-1]= +arr[i];
    }

    //console.log(numbers);

    for(i = 1; i < n; i++){
        if(numbers[i-1] < numbers[i]){
            ++increasingSequence;
        }
        else{
            increasingSequence = 1;
        }

        if(increasingSequence > maxCount){
            maxCount = increasingSequence;
        }
    }

    console.log(maxCount);
}

console.log("Task 4");
solve(['8\n7\n3\n2\n3\n4\n5\n2\n4']);

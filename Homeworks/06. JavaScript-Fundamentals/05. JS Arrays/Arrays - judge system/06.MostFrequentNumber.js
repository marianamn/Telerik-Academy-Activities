function solve(args){
    var arr = args[0].split('\n').map(Number),
        n = arr[0],
        numbers = [],
        i,
        currentNumber = 0,
        maxNumber = 0,
        maxCount = 1,
        currentCount = 1;

    //console.log(arr);

    for(i = 1; i <= n; i++){
        numbers[i-1]= +arr[i];
    }

    numbers.sort(CompareForSort);

    function CompareForSort(first, second)
    {
        if (first == second)
            return 0;
        if (first < second)
            return -1;
        else
            return 1;
    }

    for(i = 0; i < n - 1; i++){
        if(numbers[i] == numbers[i + 1]){
            currentCount +=1;
            currentNumber = numbers[i];
        }
        else{
            currentCount = 1;
        }

        if(currentCount > maxCount){
            maxCount = currentCount;
            maxNumber = currentNumber;
        }
    }

    console.log(maxNumber + ' (' + maxCount + ' times)');
}

console.log("Task 4");
solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3'])


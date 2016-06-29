function solve(args){
    var n = args[0],
        numbers = args[1].split(' ').map(Number),
        count;

    //console.log(numbers);
    function largestThanNeighbours(arr){
        var count = 0;

        for(var i = 1; i < n-1; i +=1){
            if(arr[i] > arr[i-1] && arr[i] > arr[i+1]){
                count +=1;
            }
        }

        return count;
    }

    count = largestThanNeighbours(numbers);
    console.log(count);
}

solve([ '6\n-26 -25 -28 31 2 27' ]);

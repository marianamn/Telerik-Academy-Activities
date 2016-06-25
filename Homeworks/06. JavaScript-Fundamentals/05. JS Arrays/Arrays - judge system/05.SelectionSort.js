function solve(args){
    var arr = (args + '').split('\n').map(Number),
        n = arr.length,
        numbers = [],
        i,
        maxCount = 1,
        increasingSequence = 0;

    //console.log(arr);

    for(i = 0; i < n; i++){
        numbers[i-1]= +arr[i];
    }

    function selectionSort(array){
        for(var i = 0; i < array.length; i++){
            //set min to the current iteration of i
            var min = i;
            for(var j = i+1; j < array.length; j++){
                if(array[j] < array[min]){
                    min = j;
                }
            }
            swap(array, i, min);
        }
        return array;
    };

    function swap(array, firstIndex, secondIndex){
        var temp = array[firstIndex];
        array[firstIndex]  = array[secondIndex];
        array[secondIndex] = temp;
    };

    var sortedArray = selectionSort(numbers);
    console.log(sortedArray.join('\n'));
}

console.log("Task 4");
solve(['6\n3\n4\n1\n5\n2\n6']);
solve(['10\n36\n10\n1\n34\n28\n38\n31\n27\n30\n20']);
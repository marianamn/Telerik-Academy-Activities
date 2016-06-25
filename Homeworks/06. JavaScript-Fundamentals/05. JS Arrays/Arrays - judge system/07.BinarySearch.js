function solve(args){
    var arr = args[0].split('\n').map(Number),
        n = arr[0],
        number = arr[n+1],
        numbers = [],
        i;

    for(i = 1; i <= n; i++){
        numbers[i-1]= +arr[i];
    }

    //numbers.sort(CompareForSort);
    //console.log(numbers);
    //console.log(number);

    function CompareForSort(first, second)
    {
        if (first == second)
            return 0;
        if (first < second)
            return -1;
        else
            return 1;
    }

    function binarySearch(searchElement, searchArray) {
        'use strict';

        var stop = searchArray.length;
        var last, p = 0,
            delta = 0;

        do {
            last = p;

            if (searchArray[p] > searchElement) {
                stop = p + 1;
                p -= delta;
            } else if (searchArray[p] === searchElement) {
                // FOUND A MATCH!
                return p;
            }

            delta = Math.floor((stop - p) / 2);
            p += delta; //if delta = 0, p is not modified and loop exits

        }while (last !== p);

        return -1; //nothing found

    };

    var result = binarySearch(number, numbers);
    console.log(result);
}

console.log("Task 5");
//solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);
solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32'])
//solve(['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32'])



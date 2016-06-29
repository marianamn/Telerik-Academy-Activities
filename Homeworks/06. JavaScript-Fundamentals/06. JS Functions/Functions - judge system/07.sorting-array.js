function solve(args){
    var arr = args[0].split(','),
        n = +arr[0],
        numbers = args[1].split(' ').map(Number);

    function compareForSort(first, second)
    {
        if (first == second)
            return 0;
        if (first < second)
            return -1;
        else
            return 1;
    }

    numbers.sort(compareForSort);
    console.log(numbers.join(' '));
}

solve([ '6', '3 4 1 5 2 6' ]);
solve([ '10', '36 10 1 34 28 38 31 27 30 20' ]);

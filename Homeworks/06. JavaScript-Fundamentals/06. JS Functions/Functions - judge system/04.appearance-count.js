function solve(args){
    var arr = args[0].split('\n'),
        n = +arr[0],
        numbers = arr[1].split(' ').map(Number),
        number = + arr[2],
        count;

    //console.log(numbers);
    //console.log(number);

    function countAppearance(arr, num){
        var count = 0;

        for(var i = 0; i < arr.length; i+=1){
            if(arr[i] === num){
                count +=1;
            }
        }

        return count;
    }

    count = countAppearance(numbers, number);
    console.log(count);
}

solve([ '8\n28 6 21 6 -7856 73 73 -56\n73' ]);
//solve([
//    '8',
//    '28 6 21 6 -7856 73 73 -56',
//    '73',
//])

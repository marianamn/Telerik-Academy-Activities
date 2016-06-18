function solve(args){
    var i,
        array = [];

    for(i = 0; i < args.length; i++){
        array[i] = +args[i];
    }

    var sum = 0,
        count = 0,
        min = array[0],
        max = array[0],
        avg = 0;

    for(i = 0; i < array.length; i++){
        sum += array[i];
        count++;

        if(array[i] < min){
            min = array[i];
        }

        if(array[i] > max){
            max = array[i];
        }
    }

    avg = sum / count;

    console.log('min=' + Number(min).toFixed(2));
    console.log('max=' + Number(max).toFixed(2));
    console.log('sum=' + Number(sum).toFixed(2));
    console.log('avg=' + Number(avg).toFixed(2));
}

solve(['2', '5', '1']);
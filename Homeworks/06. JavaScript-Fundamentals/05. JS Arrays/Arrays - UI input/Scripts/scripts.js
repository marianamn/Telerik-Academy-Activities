function task1() {
    var array = [];
    array.length = 20;
    for (var i = 0; i < array.length; i++) {
        array[i] = i * 5;
    }

    jsConsole.writeLine('Problem 1:');
    jsConsole.write(array.join(", "));

    console.log('Problem 1:');
    console.log(array.join(", "));
}

function task2() {
    var input1 = document.getElementById('problem2-a').value;
    var first = input1.split(", ");

    var input2 = document.getElementById('problem2-b').value;
    var second = input2.split(", ");

    var length = Math.max(first.length, second.length);
    var result = '';

    if (first.length > second.length) {
        result = 'Second char array comes first.';
    }
    else if (first.length < second.length) {
        result = 'First char array comes first.';
    }
    else {
        for (var i = 0; i < length; i++) {
            if (first[i] > second[i]) {
                result = 'Second char array comes first.';
                break;
            }
            else if (first[i] < second[i]) {
                result = 'First char array comes first.';
                break;
            }
            else {
                result = 'Both char arrays are equal.';
            }
        }
    }

    jsConsole.writeLine('Problem 2:');
    jsConsole.writeLine('first=[' + first + ']');
    jsConsole.writeLine('second=[' + second + ']');
    jsConsole.writeLine(result);

    console.log('Problem 2:');
    console.log('first=[' + first + ']');
    console.log('second=[' + second + ']');
    console.log('Lexicographically comparison: ' + result);
}

function task3() {
    var input = document.getElementById('problem3').value;
    var array = input.split(", ");

    var currentSequence = array[0];
    var maxSequence = [];

    for (var i = 0; i < array.length-1; i++) {
        if (array[i] == array[i+1]) {
            currentSequence += ", " + array[i + 1];
        }
        else {
            currentSequence = array[i + 1];
        }

        if (currentSequence.length > maxSequence.length) {
            maxSequence = currentSequence;
        }
        else
        {
            continue;
        }
    }

    jsConsole.writeLine('Problem 3:');
    jsConsole.writeLine('max sequence=[' + maxSequence + ']');
    console.log('Problem 3:');
    console.log('max sequence=[' + maxSequence + ']');
}

function task4() {
    var input = document.getElementById('problem4').value;
    var array = input.split(", ");

    var currentSequence = array[0];
    var maxSequence = [];

    for (var i = 0; i < array.length - 1; i++) {
        if (array[i] < array[i + 1]) {
            currentSequence += ", " + array[i + 1];
        }
        else {
            currentSequence = array[i + 1];
        }

        if (currentSequence.length > maxSequence.length) {
            maxSequence = currentSequence;
        }
        else {
            continue;
        }
    }

    jsConsole.writeLine('Problem 4:');
    jsConsole.writeLine('max increasing sequence=[' + maxSequence + ']');
    console.log('Problem 4:');
    console.log('max increasing sequence=[' + maxSequence + ']');
}


function task5() {
    var input = document.getElementById('problem5').value;
    var array = input.split(", ").map(Number);

    var min;
    var temp;

    for (var i = 0; i < array.length - 1; i++) {
        min = i;
        for (var j = i + 1; j < array.length; j++) {
            if (array[j] < array[min]) {
                min = j;
            }
        }
        temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }

    jsConsole.writeLine('Problem 5:');
    jsConsole.writeLine('Sorted array=[' + array + ']');
    console.log('Problem 5:');
    console.log('Sorted array=[' + array + ']');
}

function task6() {
    var input = document.getElementById('problem6').value;
    var array = input.split(", ").map(Number);

    var count = 1;
    var maxCount = 1;
    var frequent = array[0];

    //sorting the array
    function orderBy(a, b) {
        return (a == b) ? 0 : (a > b) ? 1 : -1;
    }
    array.sort(orderBy);

    for (var i = 0; i < array.length-1; i++) {
        if (array[i] == array[i+1]) {
            count++;
            frequent = array[i];
        }
        else {
            count = 1;
            frequent = array[i];
        }

        if (count > maxCount) {
            maxCount = count;
        }
    }

    jsConsole.writeLine('Problem 6:');
    jsConsole.writeLine('most frequent number: ' + frequent + ' (' + maxCount + ' times)');
    console.log('Problem 6:');
    console.log('most frequent number: ' + frequent +  '(' + maxCount + ' times)');
}

function task7() {
    var input = document.getElementById('problem7-a').value;
    var array = input.split(", ").map(Number);
    var key = document.getElementById('problem7-b').value;

    //sorting the array
    function orderBy(a, b) {
        return (a == b) ? 0 : (a > b) ? 1 : -1;
    }
    array.sort(orderBy);

    var imin = 0;
    var imax = array.length;

    while (imax >= imin)
    {
        var imid = imin + ((imax - imin) / 2);  // calculate the midpoint for roughly equal partition
        if (array[imid] == key)
        {
            jsConsole.writeLine('Problem 7:');
            jsConsole.writeLine('sorted array=[' + array + ']');
            jsConsole.writeLine('number ' + key + ' found at index [' + imid + ']');  // key found at index imid
            console.log('Problem 7:');
            console.log('sorted array=[' + array + ']');
            console.log('number ' + key + ' found at index [' + imid + ']');
            break; 
        }
        else if (array[imid] < key)         // determine which subarray to search
        {
            imin = imid + 1;                // change min index to search upper subarray
        }
        else
        {
            imax = imid - 1;                // change max index to search lower subarray
        }
    }
}
//problem 1
function task1(){
    var n = parseInt(document.getElementById('problem1').value);

    for (var i = 1; i <= n; i++) {
        jsConsole.write(i + ' ')
        console.log(i + ' ');
    }
    jsConsole.writeLine()
    console.log();
}

//problem 2
function task2() {
    var n = parseInt(document.getElementById('problem2').value);

    for (var i = 1; i <= n; i++) {
        if ((i % 3 != 0) ||(i % 7 != 0)) {
            jsConsole.write(i + ' ')
            console.log(i + ' ');
        }
    }
    jsConsole.writeLine()
    console.log();
}

//problem 3
function task3() {
    var input = document.getElementById('problem3').value;
    var array = input.split(", ").map(Number);
    var min, max;
    min = max = array[0];

    for (var i = 0; i < array.length; i++) {
        if (min > array[i]) {
            min = array[i];
        } array
        if (max < array[i]) {
            max = array[i];
        }
    }

    jsConsole.writeLine('min=' + min + ' ' + 'max=' + max);
    console.log('min=' + min + ' ' + 'max=' + max);
}

//problem 4
function task4() {
    jsConsole.writeLine('Lexicographically smallest/largest property in document:');
    console.log('Lexicographically smallest and largest property in document:');
    findSmallest(document);
    findLargest(document);

    jsConsole.writeLine('Lexicographically smallest/largest property in window:');
    console.log('Lexicographically smallest and largest property in window:');
    findSmallest(window);
    findLargest(window);

    jsConsole.writeLine('Lexicographically smallest/largest property in navigator:');
    console.log('Lexicographically smallest and largest property in navigator:');
    findSmallest(navigator);
    findLargest(navigator);
}

function findSmallest(object) {
    var smallest = 'zzz';
    for (var property in object) {
        if (property < smallest) {
            smallest = property;
        }
    }
    jsConsole.writeLine('smallest: ' + smallest);
    console.log('smallest: ' + smallest);
}

function findLargest(object) {
    var largest = 'aaa';
    for (var property in object) {
        if (property > largest) {
            largest = property;
        }
    }
    jsConsole.writeLine('largest: ' + largest);
    console.log('largest: ' + largest);
    jsConsole.writeLine('');
    console.log('');
}
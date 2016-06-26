function solve(args){
    var firstElement = args[0],
        arr = [];

    for(var i = 1; i < args.length; i+=1){
        arr[i-1] = args[i];
    }

    Array.prototype.remove = function (value) {
        while (true) {
            var index = this.indexOf(value, index);
            if (index !== -1) {
                this.splice(index, 1);
            }
            else {
                break;
            }
        }
    };

    arr.remove(firstElement);

    console.log(arr.join('\n'));
}

solve([ '1', '2', '3', '2', '1', '2', '3', '2', '1' ]);

solve([
    '_h/_',
    '^54F#',
    'V',
    '^54F#',
    'Z285',
    'kv?tc`',
    '^54F#',
    '_h/_',
    'Z285',
    '_h/_',
    'kv?tc`',
    'Z285',
    '^54F#',
    'Z285',
    'Z285',
    '_h/_',
    '^54F#',
    'kv?tc`',
    'kv?tc`',
    'Z285'
]);

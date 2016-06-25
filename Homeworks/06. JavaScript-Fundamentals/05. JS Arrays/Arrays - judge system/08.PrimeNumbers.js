function solve(args) {
    var n = +args[0],
        i,
        j,
        isPrime;

    for (i = n; i >= 0; i -= 1) {
        isPrime = true;

        for (j = 2; j <= Math.sqrt(i); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime === true) {
            return i;
        }
    }
}

var result = solve(['13']);
console.log(result);
//solve(['126']);
//solve(['26']);
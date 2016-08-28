/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/


//BG.Coder solution
function solve() {
    return function findPrimes(startRange, endRange) {
        startRange = startRange * 1;
        endRange = endRange * 1;

        if (isNaN(startRange) || isNaN(endRange)) {
            throw new Error('params must be Number')
        }

        var divisor,
            maxDivisor,
            isPrime,
            i,
            primes = [];

        for (i = startRange; i <= endRange; i += 1) {
            maxDivisor = Math.sqrt(i);
            isPrime = true;

            for (divisor = 2; divisor <= maxDivisor; divisor += 1) {
                if (i % divisor === 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i > 1) {
                primes.push(i);
            }

        }

        return primes;
    }
}


//Node.js Test
function findPrimes(startRange, endRange) {
    startRange = startRange * 1;
    endRange = endRange * 1;

    if (isNaN(startRange) || isNaN(endRange)) {
        throw new Error('params must be Number')
    }

    var divisor,
        maxDivisor,
        isPrime,
        i,
        primes = [];

    for (i = startRange; i <=endRange; i += 1) {
        maxDivisor = Math.sqrt(i);
        isPrime = true;

        for (divisor = 2; divisor <= maxDivisor; divisor+=1) {
            if (i % divisor === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime && i>1) {
            primes.push(i);
        }

    }
    
    return primes;
}

module.exports = findPrimes;

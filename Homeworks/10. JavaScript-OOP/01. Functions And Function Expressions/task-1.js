/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

//BG.Coder solution
function solve() {
    return function sum(arr) {
        if (arr.length === 0) {
            return null;
        }

        return arr.reduce(function (sum, number) {
            number = number * 1;

            if (isNaN(number)) {
                throw new Error('element must be number')
            }
            else {
                return sum += number;
            }
        }, 0)
    }
}


//Node.js Test
function sum(arr) {
    if (arr.length === 0) {
        return null;
    }

    return arr.reduce(function (sum, number) {
        number = number * 1;

        if (isNaN(number)) {
            throw new Error('element must be number')
        }
        else {
            return sum += number;
        }
    }, 0)
}
module.exports = sum;
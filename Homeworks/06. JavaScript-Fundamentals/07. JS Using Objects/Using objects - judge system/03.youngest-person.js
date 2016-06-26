function solve(args){
    var people=[];

    for(var i = 0; i < args.length - 2; i += 1){
        var person = new makePerson(args[i], args[i + 1], args[i + 2]);

        people.push(person);
    }

    function makePerson(fname, lname, age) {
        return {
            firstName: fname,
            lastName: lname,
            age: age,
            fullName: function () {
                return this.firstName + ' ' + this.lastName;
            }
        }
    }

    function youngestPerson(arr) {
        var youngest = arr[0],
            minAge = +arr[0].age;

        for (var i = 0; i < arr.length; i++) {
            if (+arr[i].age < minAge) {
                youngest = arr[i];
                minAge = +arr[i].age;
            }
        }

        return youngest;
    }

    var youngestPers = youngestPerson(people);
    console.log(youngestPers.fullName());
}

solve([ 'Gosho', 'Petrov', '32', 'Bay', 'Ivan', '81', 'John', 'Doe', '42' ]);

solve([
    'Penka',
    'Hristova',
    '22',
    'System',
    'Failiure',
    '88',
    'Bat',
    'Man',
    '14',
    'Malko',
    'Kote',
    '18'
]);

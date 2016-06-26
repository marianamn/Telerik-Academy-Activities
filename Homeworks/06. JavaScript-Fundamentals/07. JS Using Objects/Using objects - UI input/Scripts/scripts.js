function print(result) {
    jsConsole.writeLine(result);
    console.log(result);
}

//Problem 1
function task1() {
    function Point(x, y) {
        this.coordinateX = x;
        this.coordinateY = y;
    }

    var pointA = new Point(3, 5);
    var pointB = new Point(-2, 4);
    var pointC = new Point(3.5, 0);
    var pointD = new Point(2, 3);
    var pointE = new Point(-3, 7.3);
    var pointF = new Point(5, 1);

    print('-------------------');
    print('Problem 1:');
    print('-------------------');
    print('Points coordinates:');
    print('--> A (' + pointA.coordinateX + ',' + pointA.coordinateY + ')');
    print('--> B (' + pointB.coordinateX + ',' + pointB.coordinateY + ')');
    print('--> C (' + pointC.coordinateX + ',' + pointC.coordinateY + ')');
    print('--> D (' + pointD.coordinateX + ',' + pointD.coordinateY + ')');
    print('--> E (' + pointE.coordinateX + ',' + pointE.coordinateY + ')');
    print('--> F (' + pointF.coordinateX + ',' + pointF.coordinateY + ')');

    function Line(startPoint, endPoint) {
        this.start = startPoint;
        this.end = endPoint;
    }

    var line1 = new Line(pointA, pointB);
    var line2 = new Line(pointC, pointD);
    var line3 = new Line(pointE, pointF);

    var a = distanceBetweenPoints(pointA, pointB).toFixed(2);
    var b = distanceBetweenPoints(pointC, pointD).toFixed(2);
    var c = distanceBetweenPoints(pointE, pointF).toFixed(2);

    print('Lines coordinates:');
    print('--> Line 1 (A(' + pointA.coordinateX + ',' + pointA.coordinateY + '), B(' + pointB.coordinateX + ',' + pointB.coordinateY + '))');
    print('--> Line 2 (C(' + pointC.coordinateX + ',' + pointC.coordinateY + '), D(' + pointD.coordinateX + ',' + pointD.coordinateY + '))');
    print('--> Line 3 (E(' + pointE.coordinateX + ',' + pointE.coordinateY + '), F(' + pointF.coordinateX + ',' + pointF.coordinateY + '))');

    print('Distance between A and B (Line 1 lenght) --> a=' + a);
    print('Distance between C and D (Line 2 lenght) --> b=' + b);
    print('Distance between E and F (Line 3 lenght) --> c=' + c);

    print('Can these three lines form a triangle? --> ' + canFormTriangle(a, b, c));

    function distanceBetweenPoints(point1, point2) {
        var distance = Math.sqrt((point2.coordinateX - point1.coordinateX) * (point2.coordinateX - point1.coordinateX) +
            (point2.coordinateY - point1.coordinateY) * (point2.coordinateY - point1.coordinateY));
        return distance;
    }

    function canFormTriangle(a, b, c) {
        var canThreeLinesFormTriangle;
        if ((a * c + b * c) > c && (a * b + b * c) > b && (c * a + b * a) > a) {
            canThreeLinesFormTriangle = true;
        }
        else {
            canThreeLinesFormTriangle = false;
        }
        return canThreeLinesFormTriangle;
    }
}

//Problem 2
function task2() {
    var input = document.getElementById('problem2-a').value;
    var arr = input.split(", ");
    var number = document.getElementById('problem2-b').value;

    print('-------------------');
    print('Problem 2:')
    print('-------------------');
    print('Initial array=[' + arr.join(', ') + ']');

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

    arr.remove(number);
    print('After removed number array=[' + arr.join(', ') + ']');
}

//Problem 3
function task3() {
    var obj = {
        firstName: 'Ivan',
        age: 25,
        marks: [3, 5, 6],
        universityInfo: {
            name: 'SU',
            course: 2
        },
        toString: function personToString() {
            return this.firstName + '; age: ' + this.age + '; marks: ' + this.marks + '; university: '
                + this.universityInfo.name + '; course: ' + this.universityInfo.course;
        }
    }
    
    print('-------------------');
    print('Problem 3')
    print('-------------------');
    print('-- > Original object:')
    print(obj);

    var deepCopy = createDeepCopy(obj);
    print('-- > Deep copy of an object:')
    print(deepCopy);

    obj.firstName = 'Georgi';
    obj.age = 30;
    obj.marks = [4];
    obj.universityInfo.name = 'Oxford';

    print('-- > Changed object:')
    print(obj);

    print('-- > Deep copy remains unchanged:')
    print(deepCopy);


    function createDeepCopy(obj) {
        if (obj === null || typeof obj !== 'object') {
            return obj;
        }

        var copy = obj.constructor();
        for (var prop in obj) {
            copy[prop] = createDeepCopy(obj[prop]);
        }

        return copy;
    }
}

//Problem 4
function task4(){
    var student = {
        firstName: 'Ivan',
        lastName: 'Ivanov',
        age: 24,
        marks: [2, 3, 4, 5],
        toString: function () {
            return 'first name: ' + this.firstName + '; last name: ' + this.lastName + '; age: ' +
                this.age + '; marks: ' + this.marks;
        }
    }

    print('-------------------');
    print('Problem 4')
    print('-------------------');
    print('-- > Student:')
    print(student);

    var prop = 'marks';
    print('Is student has property ' + prop + '? --> ' + hasProperty(student, prop));
    var prop = 'age';
    print('Is student has property ' + prop + '? --> ' + hasProperty(student, prop));
    var prop = 'hair';
    print('Is student has property ' + prop + '? --> ' + hasProperty(student, prop));

    function hasProperty(obj, property) {
        hasProp = false;
        for (var prop in obj) {
            if(prop === property){
                hasProp = true;
            }
        }

        return hasProp;
    }
}

//Problem 5
function task5() {
    function Person(firstName, lastName, personAge) {
        this.fname = firstName;
        this.lname = lastName;
        this.age = personAge;
        this.toString = function() {
            return this.fname + ' ' + this.lname + ', ' + this.age;
        }
        this.fullName = function () {
            return this.fname + ' ' + this.lname;
        }
    }

    var people = [
         new Person('Gosho', 'Petrov', 32),
         new Person('Bay', 'Ivan', 81),
         new Person('Pesho', 'Goshev', 11)];

    print('-------------------');
    print('Problem 5')
    print('-------------------');
    print('-- > Persons:');

    for (var i = 0; i < people.length; i++) {
        print(people[i].toString());
    }
    
    print('-- > Youngest person full name:');
    print(youngestPerson(people).fullName());

    function youngestPerson(arr) {
        var youngest = arr[0];
        var minAge = arr[0].age;

        for (var i = 0; i < arr.length; i++) {
            if (arr[i].age < minAge) {
                arr[i].age = minAge;
                youngest = arr[i];
            }
        }

        return youngest;
    }
}

//problem 6
function task6() {
    function Person(firstName, lastName, personAge) {
        this.fname = firstName;
        this.lname = lastName;
        this.age = personAge;
        this.toString = function () {
            return this.fname + ' ' + this.lname + ', ' + this.age;
        }
    }

    var people = [
         new Person('Gosho', 'Petrov', 32),
         new Person('Bay', 'Ivan', 81),
         new Person('Pesho', 'Goshev', 11)];


    print('-------------------');
    print('Problem 6')
    print('-------------------');
    print('-- > Persons:');

    for (var i = 0; i < people.length; i++) {
        print(people[i].toString());
    }

    var groupedByAge = groupPeopleBy(people, "age");
    print('Grouped by age');
    printObj(groupedByAge);

    var groupedByFname = groupPeopleBy(people, "fname");
    print('Grouped by first name');
    printObj(groupedByFname);
    
    var groupedByLname = groupPeopleBy(people, "lname");
    print('Grouped by last name');
    printObj(groupedByLname);

    function groupPeopleBy(arr, prop) {
        var resultArr = new Object();
        for (var person in arr) {
            var temp = arr[person][prop];
            if (resultArr[temp] === undefined || resultArr[temp] === null) {
                resultArr[temp] = [];
            };
            resultArr[arr[person][prop]].push(arr[person]);
        }
        return resultArr;
    }

    function printObj(obj){
        for (var item in obj) {
            if (item !== "undefined") {
                print(item);
            }
        }
    }

}
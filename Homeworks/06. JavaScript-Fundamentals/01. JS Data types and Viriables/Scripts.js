//JS literals ifo - http://www.w3resource.com/javascript/variables-literals/literals.php
//when testing: run html and see F12/Console

//Problem 1
var integerLiteral = 5;
var floatLiteral = 2.34;
var stringLiteral = 'Pesho';
var arrayLiteral = [1, 3, 5];
var objectLiteral = { student: 'Ivan', studentNum: 123456 };
var booleanLiteral = integerLiteral > floatLiteral;
console.log('Problem 1:');
console.log('integerLiteral =', integerLiteral);
console.log('floatLiteral =', floatLiteral);
console.log('stringLiteral =', stringLiteral);
console.log('arrayLiteral =', arrayLiteral);
console.log('objectLiteral =', objectLiteral);
console.log('booleanLiteral =', booleanLiteral);

//Problem 2
var quotedText = '\'How you doin\'?\', Joey said';
console.log('Problem 2:');
console.log('Quoted Text:', quotedText);

//Problem 3
console.log('Problem 3:');
console.log('Typeof integerLiteral:', typeof (integerLiteral));
console.log('Typeof floatLiteral:', typeof (floatLiteral));
console.log('Typeof stringLiteral:', typeof (stringLiteral));
console.log('Typeof arrayLiteral:', typeof (arrayLiteral));
console.log('Typeof objectLiteral:', typeof (objectLiteral));
console.log('Typeof booleanLiteral:', typeof (booleanLiteral));
console.log('Typeof Quoted Text:', typeof (quotedText));

//Problem 4
var a = undefined;
var b = null;
console.log('Problem 4:');
console.log('a =', a);
console.log('b =', b);
console.log('Typeof a:', typeof (a));
console.log('Typeof b:', typeof (b));
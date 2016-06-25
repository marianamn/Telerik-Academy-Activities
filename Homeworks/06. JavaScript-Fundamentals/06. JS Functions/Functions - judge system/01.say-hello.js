function solve(args){
    var name = args[0];

    function printName(personName){
        console.log('Hello, ' + personName + '!')
    }

    printName(name);
}

solve(['Peter'])
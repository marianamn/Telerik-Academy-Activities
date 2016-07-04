function solve(args){
    var text = args[0],
        replaceWith = '&nbsp;';

    for(var i = 0; i < text.length; i += 1){
        if(text[i] === ' '){
            text = text.replace(' ', replaceWith);
        }
    }

    console.log(text);
}

solve([
    'This text contains 4 spaces!!'
]);

solve([
    'hello world'
]);
function solve(args){
    var expression = args[0],
        openBrackets = 0,
        closedBrackets = 0;

    var len = expression.length;
    for (var i = 0; i < len; i+=1){
        if(expression[i] === '('){
            openBrackets +=1;
        }
        else if(expression[i] === ')'){
            closedBrackets +=1;
        }
    }

    if(openBrackets === closedBrackets){
        console.log('Correct');
    }
    else{
        console.log('Incorrect');
    }
}

solve([ '((a+b)/5-d)' ]);
solve([ ')(a+b))' ]);
function solve(args){
    var pattern = args[0].toLowerCase(),
        text = args[1].toLowerCase(),
        count = 0,
        position = 0,
        textLen= text.length,
        patternLen = pattern.length,
        position = 0;

    position = text.indexOf(pattern);

    while (position >= 0) {
        count += 1;

        text= text.substring(position +1);

        position = text.indexOf(pattern);

    }

    console.log(count);
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);
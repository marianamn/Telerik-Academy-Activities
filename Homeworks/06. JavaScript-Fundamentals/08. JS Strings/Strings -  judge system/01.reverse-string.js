function solve(args){
    var text = args[0],
        reversed = '';

    for(var i = text.length - 1 ; i>=0; i-=1){
        reversed += text[i];
    }

    console.log(reversed);
}

solve ([ 'sample' ]);
solve ([ 'qwertytrewq' ]);
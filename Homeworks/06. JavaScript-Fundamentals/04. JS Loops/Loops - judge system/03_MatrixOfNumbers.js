function solve(args) {
    var n = +args[0],
        row,
        col,
        i,
        j,
        line = "",
        matrix = [];

    //creating matrix
    for (row = 0; row < n; row++) {
        matrix[row] = [];

        for (col = 0; col < n; col++) {
            matrix[row][col] = col + row + 1;
        }
    }

    //print matrix
    for(i = 0; i < n; i++) {
        line = matrix[i];
        console.log(line.join(' '));
    }
}

solve(['3']);
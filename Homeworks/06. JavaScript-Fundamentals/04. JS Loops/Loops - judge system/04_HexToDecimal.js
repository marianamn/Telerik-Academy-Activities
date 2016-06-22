function solve(args){
    var hexNumber = args[0],
        decimalNumber = 0,
        i,
        num = '',
        numericBase = 16;

    for(i = 0; i < hexNumber.length; i++){
        num = hexNumber[hexNumber.length - 1 - i];

        switch (num)
        {
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9": break;
            case "A":
                num = "10";
                break;
            case "B":
                num = "11";
                break;
            case "C":
                num = "12";
                break;
            case "D":
                num = "13";
                break;
            case "E":
                num = "14";
                break;
            case "F":
                num = "15";
                break;
        }

        decimalNumber += parseInt(num) * Math.pow(numericBase, i)
    }

    console.log(decimalNumber);
}

solve(['1AE3']);
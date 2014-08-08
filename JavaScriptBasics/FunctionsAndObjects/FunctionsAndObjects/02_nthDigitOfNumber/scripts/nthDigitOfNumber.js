function findNthDigit(inputValue) {
    var number = parseInt(inputValue[1]);
    if (number < 0) {
        number *= -1;
    }
    if (inputValue[0] > number.toString().split('').length) {
        return "The number doesn't have " + inputValue[0] + " digits";
    }    
    var digit = parseInt(number / Math.pow(10,(inputValue[0]-1)));
    switch (digit) {
        case 0:
            return "Zero";
            break;
        case 1:
            return "0ne";
            break;
        case 2:
            return "Two";
            break;
        case 3:
            return "Three";
            break;
        case 4:
            return "Four";
            break;
        case 5:
            return "Five";
            break;
        case 6:
            return "Six";
            break;
        case 7:
            return "Seven";
            break;
        case 8:
            return "Eight";
            break;
        case 9:
            return "Nine";
            break;
        default:
            return "Not a digit!";
    }
}
console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([6, 888.88]));

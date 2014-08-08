function decToHex(input) {
    var decNumber = parseInt(input);
    var result = "";
    while (decNumber > 0) {
        var reminder = parseInt(decNumber % 16);
        switch (reminder) {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                result += reminder;
                break;
            case 10:
                result += "A";
                break;
            case 11:
                result += "B";
                break;
            case 12:
                result += "C";
                break;
            case 13:
                result += "D";
                break;
            case 14:
                result += "E";
                break;
            case 15:
                result += "F";
                break;
        }
        decNumber = parseInt(decNumber / 16);
    }
    var reverseArr = result.toString().split('');
    result = "";
    for (var i = reverseArr.length - 1; i >= 0; i--) {
        result += reverseArr[i];
    }
    return result;
}
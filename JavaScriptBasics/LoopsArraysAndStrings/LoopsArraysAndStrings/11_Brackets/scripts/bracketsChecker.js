function checkBrackets(inputValue) {
    var str = inputValue;
    var leftBrackets = 0;
    var rightBrackets = 0;
    for (var ch in str) {
        if (str[ch] == '(') {
            leftBrackets++;
        }
        else if (str[ch] == ')') {
            rightBrackets++;
        }
    }

    if (leftBrackets == rightBrackets) {
        return "correct";
    }
    else {
        return "incorrect";
    }
}
console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));
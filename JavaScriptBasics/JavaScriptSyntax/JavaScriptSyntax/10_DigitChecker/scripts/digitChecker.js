function checkDigit(inputValue) {
    var tempValue = Math.floor(inputValue / 100);
    var result = tempValue % 10;
    return result == 3 ? true : false;
}
console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));
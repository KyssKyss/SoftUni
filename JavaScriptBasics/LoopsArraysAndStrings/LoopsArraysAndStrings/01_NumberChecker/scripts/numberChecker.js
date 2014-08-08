function printNumbers(inputValue) {
    var arr = new Array();
    var index = 0;
    if (inputValue <= 0) {
        return 'no';
    }
    for (var i = 1; i <= inputValue; i++) {
        if (Math.floor(i % 5 != 0) && Math.floor(i % 4 != 0)) {
            arr[index++] = i;
        }
    }
    return arr.toString();
}
console.log(printNumbers(20));
console.log(printNumbers(-5));
console.log(printNumbers(13));
function createArray(inputValue) {
    for (var i in inputValue) {
        inputValue[i] *= 5;
    }
    return inputValue;
}
console.log(createArray([1, 2, 1, 15, 20, 5, 7, 31, 1, 2, 1, 15, 20, 5, 7, 31, 1, 2, 1, 15, 20, 5, 7, 31]));
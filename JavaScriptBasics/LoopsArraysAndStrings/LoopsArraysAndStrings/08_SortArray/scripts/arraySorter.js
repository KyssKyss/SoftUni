function sortArray(inputValue) {
    var tempVar = 0;
    for (var i = 0; i < inputValue.length; i++) {
        for (var j = 0; j < inputValue.length - 1; j++) {
            if(inputValue[j] > inputValue[j + 1]) {
                tempVar = inputValue[j];
                inputValue[j] = inputValue[j + 1];
                inputValue[j + 1] = tempVar;                
            }
        }
    }
    return inputValue.toString();
}
console.log(sortArray([5, 4, 3, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));
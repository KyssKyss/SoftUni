function findMaxSequence(inputValue) {
    var number = 0;
    var counter = 0;
    var maxCounter = 0;
    var arr = new Array();
    if (inputValue.length === 1) {
        arr[0] = inputValue[0];
        return arr;
    }
    for (var i = 0; i < inputValue.length - 1; i++) {
            if (inputValue[i] === inputValue[i + 1]) {
                counter++;
                if (maxCounter <= counter) {
                    number = arguments[0][i];
                    maxCounter = counter;
                }
            }
            else {
                counter = 1;
            }
        }
    for (var i = 0; i < maxCounter; i++) {
        arr[i] = number;
    }
    return arr;
}
console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
function findMostFreqNum(inputValue) {
    var mostFreqNumber = 0;
    var counter = 0;
    var maxCounter = 1;
    for (var i = 0; i < inputValue.length; i++) {
        for (var j = 0; j < inputValue.length; j++) {
            if(inputValue[i] === inputValue[j]) {
                counter++;
                if (maxCounter < counter) {
                    maxCounter = counter;
                    mostFreqNumber = inputValue[i];
                }
            }
        }
        counter = 0;
    }
    if (maxCounter === 1) {
        mostFreqNumber = inputValue[0];
    }
    return mostFreqNumber + ' (' + maxCounter + ' times)';
}
console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
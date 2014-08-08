function maxSequenceFinder(inputValue) {
    var arr = new Array();
    var counter = 1;
    var maxCounter = 0;
    for (var i = 0; i < inputValue.length - 1; i++) {
        if (inputValue[i] < inputValue[i + 1]) {
            counter++;
        }
        else {
            counter = 1;
        }
        if(counter > maxCounter) {
            maxCounter = counter;
            for (var j = 0; j < counter; j++) {
                arr[j] = inputValue[i - counter + 2 + j];
            }
        }
        else if (maxCounter < 2) {
            return "no";
        }            
    }  
    return arr;
}
console.log(maxSequenceFinder([3, 2, 3, 4, 2, 2, 4]));
console.log(maxSequenceFinder([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(maxSequenceFinder([2, 6, 22, 51, 712, 1, 3, 6, 12, 18, 50]));
console.log(maxSequenceFinder([3, 2, 1]));
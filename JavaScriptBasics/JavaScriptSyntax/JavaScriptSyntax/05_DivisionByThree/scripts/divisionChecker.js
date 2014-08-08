function divisionBy3(inputValue) {
    var arr = new Array;
    var counter = 0;
    var sum = 0;
    if (inputValue > 10) {
        while (inputValue > 0) {
            arr[counter] = inputValue % 10;
            inputValue = Math.floor(inputValue / 10);
            counter++;
        }
        for (var i = 0; i < counter; i++) {
            sum += arr[i];
        }
    }
    else {
        sum = inputValue;
    }
    if (sum % 3 !== 0) {
        return "the number is not divided by 3 without remainder";
    }
    else {
        return "the number is divided by 3 without remainder";
    }
}
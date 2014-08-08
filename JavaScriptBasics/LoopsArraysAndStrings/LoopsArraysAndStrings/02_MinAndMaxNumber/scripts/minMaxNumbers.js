function findMinAndMax(input) {
    var min = input[0];
    var max = 0;
    for (var i = 0; i < input.length; i++) {
        var temp = input[i];
        if (temp > max) {
            max = temp;
        }
        else if (temp < min) {
            min = temp;
        }
    }
    return "Min -> " + min + "\n" + "Max -> " + max;
}
console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));
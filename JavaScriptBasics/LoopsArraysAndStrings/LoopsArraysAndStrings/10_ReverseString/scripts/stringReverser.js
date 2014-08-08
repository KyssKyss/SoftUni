function reverseString(inputValue) {
    var str = '';
    for (var i = inputValue.length - 1; i >= 0; i--) {
        str += inputValue[i];
    }
    return str;
}
console.log(reverseString('sample'));
console.log(reverseString('softUni'));
console.log(reverseString('java script'));
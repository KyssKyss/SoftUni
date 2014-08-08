function reverseWordsInString(inputValue) {
    var tempArr = inputValue.split(' ');
    var resultString = '';
    for (var e in tempArr) {
        resultString += tempArr[e].split('').reverse().join('') + ' ';
    }
    return resultString;
}
console.log(reverseWordsInString('Hello, how are you.'));
console.log(reverseWordsInString("Life is pretty good, isn't it?"));
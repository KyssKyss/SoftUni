function findPalindromes(inputValue) {
    var strArr = inputValue.toLowerCase().replace(/[.*,*]/g,'').split(/\s+/g);
    var result = new Array();
    var index = 0;
    for (var i = 0; i < strArr.length; i++) {
        var len = strArr[i].length;
        for (var j = 0; j < len ; j++) {
            if (strArr[i][j] !== strArr[i][len - 1 - j]) {
                break;
            }
            else {
                result[index++] = strArr[i];
                break;
            }
        }        
    }
    return result.toString();
}
console.log(findPalindromes('There is a man, his name was Bob.'));
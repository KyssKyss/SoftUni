function biggerThanNeighbors(index, inputArr) {
    var index = index;
    var number = parseInt(inputArr[index]);
    var leftSide = parseInt(inputArr[index - 1]);
    var rightSide = parseInt(inputArr[index + 1]);
    if (inputArr[index] === undefined) {
        return "invalid index";
    }
    if (index === 0) {
        return "only one neighbor";
    }
    if ((number > leftSide) && (number > rightSide)){
        return "bigger";
    }
    else if ((number <= leftSide) || (number <= rightSide)) {
        return "not bigger";
    }
}
//console.log(biggerThanNeighbors(2, [1, 2, 3, 3, 5]));
//console.log(biggerThanNeighbors(2, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbors(5, [1, 2, 5, 3, 4]));
//console.log(biggerThanNeighbors(0, [1, 2, 5, 3, 4]));
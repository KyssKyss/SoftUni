function roundNumber(inputValue) {
    var roundNum = Math.round(inputValue);
    var floorNum = Math.floor(inputValue);
    
    return [floorNum, roundNum];
}
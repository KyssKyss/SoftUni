function bitChecker(inputBit) {
    var bitPosition = 3;
    var mask = inputBit >> bitPosition;
    var bit = mask & 1;
    if (bit === 1) {
        return true;
    }
    else {
        return false;
    }
}
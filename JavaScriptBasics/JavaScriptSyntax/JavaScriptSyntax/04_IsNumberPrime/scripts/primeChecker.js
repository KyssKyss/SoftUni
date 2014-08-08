function isPrime(inputValue) {
    var primeDigits = [2, 3, 5, 7];
    var index = 0;
    for (var i = 0; primeDigits[i] <= Math.sqrt(inputValue) ; i++) {
        if (inputValue % primeDigits[i] == 0) {
            return false;
        }
    }
    return true;
}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
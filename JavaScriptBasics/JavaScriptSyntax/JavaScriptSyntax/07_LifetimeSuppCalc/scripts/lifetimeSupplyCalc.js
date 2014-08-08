function calcSupply(age, maxAge, amountFPD) {
    var userAge = age;
    var result = Math.floor((maxAge - age) * (365 * amountFPD));
    var foods = ['nuts', 'chocolate', 'fruits', 'meat', 'sugar'];
    var index = Math.floor((Math.random() * 10)/2);
    return result + "kg " + "of " + foods[index] + " would be enough until I am " + maxAge + " years old."
}
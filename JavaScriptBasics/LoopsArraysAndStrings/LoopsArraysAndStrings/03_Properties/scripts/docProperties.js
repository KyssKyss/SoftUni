function displayProperties(value) {
    var arr = new Array();
    for (var element in value) {
        arr.push(element);
    }
    return arr.sort();
}
console.log(displayProperties("../index.html"));
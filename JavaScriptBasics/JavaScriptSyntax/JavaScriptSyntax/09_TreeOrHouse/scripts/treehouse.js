function treeHouseCompare(a, b) {
    var houseArea = (a * a) + (1 / 2 * a * (2 / 3 * a));
    var treeArea = ((1 / 3 * b) * b) + (Math.PI * ((b * 2 / 3)*(b * 2 / 3)));
    if (houseArea > treeArea) {
        return "house/" + houseArea.toFixed(2) ;
    }
    else {
        return "tree/" + treeArea.toFixed(2);
    }
}
console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));
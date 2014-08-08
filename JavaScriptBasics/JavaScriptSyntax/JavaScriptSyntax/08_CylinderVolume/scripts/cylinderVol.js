function calcCylinderVol(radius, height) {
    var result = Math.PI * radius * radius * height;
    return Math.round(result * 1000) / 1000;
}
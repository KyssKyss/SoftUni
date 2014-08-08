function isNumber() {
    var inputValue = document.getElementById('numField');
    if (isNaN(inputValue.value)) {
        bringError(inputValue);
    }
}
function bringError(inputValue) {
    var bgColor = inputValue.style.backgroundColor = "red";
    var disable = inputValue.disabled = true;
    setTimeout(function () { bgColor = "white"; disable = false; }, 2000);
}
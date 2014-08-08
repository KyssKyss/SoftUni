function textChange(el) {
    if (el.innerHTML == "Like") {
        el.innerHTML = "Unlike";
    }
    else {
        el.innerHTML = "Like";
    }
}
console.log(textChange());
function mouseCoordinate() {
    var mousePos;
    window.onmousemove = handleMouseMove;
    function handleMouseMove(event) {
        mousePos = {
            x: window.event.clientX,
            y: window.event.clientY
        };
        return getMousePosition();
    }
    function getMousePosition() {
        var pos = mousePos;
        var date = new Date();
        var text = document.getElementById("outputText");
        return text.innerHTML += "X:" + pos.x + "; Y:" + pos.y + " Time: " + date.toUTCString() + '<br />';
    }
}
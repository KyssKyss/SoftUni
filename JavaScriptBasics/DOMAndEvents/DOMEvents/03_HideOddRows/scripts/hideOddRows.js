var btn = document.getElementById("btnHideOddRows");
this.onclick = function () { hideRows(); };

function hideRows() {
    var tr = document.getElementsByTagName('tr');
    for (var i = 0; i < tr.length; i++) {
        if (i % 2 == 0) {
            tr[i].style.display = 'none';
            tr[i].className = 'hiddenTr';
        }
    }
}
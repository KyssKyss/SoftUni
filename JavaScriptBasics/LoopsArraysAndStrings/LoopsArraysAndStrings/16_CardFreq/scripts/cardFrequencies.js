function findCardFrequency(inputValue) {
    value = inputValue.replace(/(♣)*(♥)*(♦)*(♠)*/g, "").split(' ');
    var map = new Array();
    var totalSum = 0;

    for (var i = 0; i < value.length; i++) {
        var count = 0;
        var key = value[i];

        for (var j = 0; j < value.length; j++) {
            if (value[i] === value[j]) {
                count++;
            }
        }
        map[value[i]] = count;
    }

    for (var key in map) {
        totalSum += map[key];
    }

    for (var key in map) {
        console.log(key + " -> " + ((map[key] / totalSum) * 100).toFixed(2) + "%");
    }
    console.log("\n");
}

findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');
function findMostFreqWord(inputValue) {
    var words = inputValue.toLowerCase().replace(/[.*,*]/g, '').split(/\s+/g);
    var results = new Array();
    var maxCounter = 0;

    for (var i in words) {
        var word = words[i];
        if (results[word] === undefined) {
            results[word] = { word: word, times: 1 };
        }
        else {
            results[word].times++;
        }

        if (results[word].times > maxCounter) {
            maxCounter = results[word].times;
        }
    }

    var bestWords = [];

    for (var i in results) {
        if (results[i].times === maxCounter) {
            bestWords.push(results[i]);
        }
    }
    // thanks to anton_cholakov and stackoverflow source
    bestWords = bestWords.sort(function (a, b) {
        return a.word.localeCompare(b.word);
    });
    for (var e in bestWords) {
        console.log(bestWords[e].word + " -> " + bestWords[e].times + " times" + "\n");
    }
}
console.log(findMostFreqWord('in the middle of the night'));
console.log(findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
console.log(findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));
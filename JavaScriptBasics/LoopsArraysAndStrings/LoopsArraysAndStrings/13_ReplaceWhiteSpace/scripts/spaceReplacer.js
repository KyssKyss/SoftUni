function replaceSpaces(inputValue) {
    return inputValue = inputValue.replace(/\s+/g, '&nbsp;');
}
console.log(replaceSpaces("But you were living in another world tryin' to get your message through"));
HTMLTextAreaElement.prototype.caret = function (start, end) {
    switch(arguments.length) {
        case 0:
            return this.selectionStart;
        case 1:
            this.selectionStart = start;
            this.selectionEnd = start;
            this.focus();
        case 2:
            this.selectionStart = start;
            this.selectionEnd = end;
            this.focus();
        return;
};
HTMLTextAreaElement.prototype.careted = function () {
    //if the textarea has selection then return true
    return this.selectionStart == this.selectionEnd;
    
};
HTMLTextAreaElement.prototype.kared = function () { //return the selection text
    return this.value.substring(this.selectionStart, this.selectionEnd);
};

var textarea = document.getElementsByTagName("textarea")[0];

textarea.onkeydown = function (event) {

    //support tab on textarea
    if (event.keyCode == 9) { //tab was pressed
        var newCaretPosition;
        newCaretPosition = textarea.caret() + estb.length;
        textarea.value = textarea.value.substring(0, textarea.caret()) + estb + textarea.value.substring(textarea.caret(), textarea.value.length);
        textarea.caret(newCaretPosition);
        //tab key will blur this textarea
        return false;
    }
    if (event.keyCode == 13) {
        var cursorPos = textarea.caret;
        var curentLine = textarea.value.substr(0, this.selectionStart).split("\n").pop();
        var indent = curentLine.match(/^\s*/)[0];
        //    curentLine = curentLine + tabSpace; 
        var value = textarea.value;
        var textBefore = value.substring(cursorPos);
        var textAfter = value.substring(cursorPos, value.length);

    //    this.value = textBefore + indent + textAfter;
        console.log("textBefore:"+textBefore);
        console.log("textAfter:" + textAfter);
    }
}
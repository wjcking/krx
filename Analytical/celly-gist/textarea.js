HTMLTextAreaElement.prototype.caret = function (start, end) {
    switch (arguments.length) {
        case 0:
            return this.selectionStart;
        case 1:
            this.selectionStart = start;
            this.selectionEnd = start;
            focus();
            return;
        case 2:
            this.selectionStart = start;
            this.selectionEnd = end;
            focus();
            return;
    }
};
HTMLTextAreaElement.prototype.careted = function () {
    return selectionStart == selectionEnd;    //if the textarea has selection then return true
};
//HTMLTextAreaElement.prototype.kared = function () { //return the selection text
//    return this.value.substring(this.selectionStart, this.selectionEnd);
//};

var textarea = document.getElementsByTagName("textarea")[0];

textarea.onkeydown = function (event) {
    //support tab on textarea
    //tab was pressed;
    if (event.keyCode == 9) {
        var front = textarea.value.substring(0, textarea.caret());
        var end = textarea.value.substring(textarea.caret(), textarea.value.length);
        textarea.value = front + estab + end;
        var careted = textarea.caret() + estab.length;
        textarea.caret(careted);
        /*tab key will blur this textarea*/
        return false;
    }
    if (event.keyCode == 13) {
        //        var cursorPos = textarea.caret;
        //        var curentLine = textarea.value.substr(0, selectionStart).split("\n").pop();
        //        var indent = curentLine.match(/^\s*/)[0];
        //        //    curentLine = curentLine + tabSpace; 
        //        var value = textarea.value;
        //        var textBefore = value.substring(cursorPos);
        //        var textAfter = value.substring(cursorPos, value.length);

        //    //    value = textBefore + indent + textAfter;
        //        console.log("textBefore:"+textBefore);
        //        console.log("textAfter:" + textAfter);}
    }
};
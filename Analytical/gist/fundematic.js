HTMLTextAreaElement.prototype.getCaretPosition = function () { //return the caret position of the textarea
    return this.selectionStart;
};
HTMLTextAreaElement.prototype.setCaretPosition = function (position) { //change the caret position of the textarea
    this.selectionStart = position;
    this.selectionEnd = position;
    this.focus();
};
HTMLTextAreaElement.prototype.hasSelection = function () { //if the textarea has selection then return true
    if (this.selectionStart == this.selectionEnd) {
        return false;
    } else {
        return true;
    }
};
HTMLTextAreaElement.prototype.getSelectedText = function () { //return the selection text
    return this.value.substring(this.selectionStart, this.selectionEnd);
};
HTMLTextAreaElement.prototype.setSelection = function (start, end) { //change the selection area of the textarea
    this.selectionStart = start;
    this.selectionEnd = end;
    this.focus();
};
var textarea = document.getElementsByTagName("textarea")[0]; 
textarea.onkeydown = function(event) {
    var tabSpace="  ";
    //support tab on textarea
    if (event.keyCode == 9) { //tab was pressed
        var newCaretPosition;
        newCaretPosition = textarea.getCaretPosition() + tabSpace.length;
        textarea.value = textarea.value.substring(0, textarea.getCaretPosition()) + tabSpace + textarea.value.substring(textarea.getCaretPosition(), textarea.value.length);
        textarea.setCaretPosition(newCaretPosition);
        return false;
    }

}
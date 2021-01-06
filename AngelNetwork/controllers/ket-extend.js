
String.prototype.upperFirst = function  () {
     return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.lowerFirst = function  () {
     return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.replaceAll=    function(s2, replacement) {
    return this.replace(new RegExp(s2, 'g'), replacement);
}
String.prototype.format = function () {
    if (arguments.length == 0) {
        return this;
    }
    for (var s = this, i = 0; i < arguments.length; i++) {
        s = s.replace(new RegExp("\\{" + i + "\\}", "g"), arguments[i]);
    }
    return s;
};
String.prototype.lines = function () {
    if (this.indexOf("\r\n") > -1)
        return this.split('\r\n');

    if (this.indexOf('\n') > -1)
        return this.split('\n');

    return this.split('\r');
}
String.prototype.br = function () {
    return this + "<br/>";
}

function StringBuilder() {
    var strings = [];

    this.append = function (string) {
        string = verify(string);
        if (string.length > 0) strings[strings.length] = string;
    };

    this.appendLine = function (string) {
        string = verify(string);
        if (this.isEmpty()) {
            if (string.length > 0) strings[strings.length] = string;
            else return;
        }
        else strings[strings.length] = string.length > 0 ? "\r\n" + string : "\r\n";
    };

    this.clear = function () { strings = []; };

    this.isEmpty = function () { return strings.length == 0; };

    this.toString = function () { return strings.join(""); };

    var verify = function (string) {
        if (!defined(string)) return "";
        if (getType(string) != getType(new String())) return String(string);
        return string;
    };

    var defined = function (el) {
        // Changed per Ryan O'Hara's comment:
        return el != null && typeof (el) != "undefined";
    };

    var getType = function (instance) {
        if (!defined(instance.constructor)) throw Error("Unexpected object type");
        var type = String(instance.constructor).match(/function\s+(\w+)/);

        return defined(type) ? type[1] : "undefined";
    };
};
////String.prototype.linebrs = function (crlf) {
////    return this.lines("<br/>");
////}
////String.prototype.extent = {
////    index: 0,
////    start =0,
////    end =0,
////    color: function (param) {

////    }
////}

//};

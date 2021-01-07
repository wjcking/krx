"use strict";
let Typelect = {
    assert: function (value) {
        if (value == null) {
            const error = "[ERROR]Typelect.Assertion:value is null";
            document.write(error);
            throw error;
        }
    },
    default: function (value, defaultValue) {
        return null == value ? (defaultValue == null ? string_empty : defaultValue) : string_empty;
    },

    isString: function (value) {
        return typeof (value) == type_string;
    }

}
let logger = {
    write: function (value, color) {
        document.write( "<log style='color: " + Typelect.default(color, "red") + "'>" + value + "</log>");
    }

}

let Except = {
    track: function (funk) {
        try {
            return funk;
        } catch (e) {
            throw e.error;
        }
    }
}
/*
 * print each array by using document. write
  */
Object.prototype.logout = function (prefix, suffix) {
    this.forEach(function (e, i) {
        document.write(Typelect.default(prefix) + e + Typelect.default(suffix));
    });

}

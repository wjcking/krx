
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
//let String.prototype.ketstring = function (s) {
//    'use strict';

//    if (undefined == s)
//        return;
    
//    //function charAt(index) {
//    //   return  s.charAt(index);
//    //}
//    //function split(s2) {
//    //    return split(s2);
//    //}
//    //function concat(s2) {
//    //  return   s.concat(s2);
//    //}

//    //function indexOf(s2) {
//    //    return s.indexOf(s2);
//    //}
//    //function includes(s2) {
//    //    return s.includes(s2);
//    //}

//    //function lastIndexOf(s2) {
//    //    return s.lastIndexOf(s2);
//    //}

//    //function slice(start,end);{
//    //    return s.slice(start,end);
//    //}

//    //function substring(from, to); {
//    //    return s.substring(from,to);
//    //}
//    //function subLength(start, length); {
//    //    return s.substring(start, length);
//    //}

//    //function startsWith(s2); {
//    //    return s.startsWith(s2);
//    //}
//    //function endWith(s2); {
//    //    return s.endWith(s2);
//    //}

//    function replace(s2, replacement) {
//        return s.replace(new RegExp(s2, 'g'), replacement);
//    }
//    function match( s2) {
//        return s.match(new RegExp(s2, 'g'));
//    }

//    function upperFirst() {
//        return s.trim().toUpperCase().replace(s[0], s[0].toUpperCase());
//    }

//    function lowerFirst() {
//        return s.trim().toLowerCase().replace(s[0], s[0].toUpperCase());
//    }

//  //  try {
//    //return {
//    //    origin: s,
//    //        //charAt: charAt,
//    //        //concat: concat,
//    //        //splite: splite,
//    //        //indexOf: indexOf,
//    //        //includes: includes,
//    //        //lastIndexOf: lastIndexOf,
//    //        //substring: substring,
//    //        //subLength: subLength,
//    //        //slice: slice,
//    //        //startsWith: startsWith,
//    //        //endWith: endWith,
//    //        //length: s.length,
//    //        replace: replace,
//    //        match: match,
//    //        upperFirst: upperFirst,
//    //        lowerFirst: lowerFirst
//    //    }
// //   } catch (e) {
// //       return e;
////    }
//}

let ketstring = function (s) {
    'use strict';

    if (undefined == s)
        return;
    
    //function charAt(index) {
    //   return  s.charAt(index);
    //}
    //function split(s2) {
    //    return split(s2);
    //}
    //function concat(s2) {
    //  return   s.concat(s2);
    //}

    //function indexOf(s2) {
    //    return s.indexOf(s2);
    //}
    //function includes(s2) {
    //    return s.includes(s2);
    //}

    //function lastIndexOf(s2) {
    //    return s.lastIndexOf(s2);
    //}

    //function slice(start,end);{
    //    return s.slice(start,end);
    //}

    //function substring(from, to); {
    //    return s.substring(from,to);
    //}
    //function subLength(start, length); {
    //    return s.substring(start, length);
    //}

    //function startsWith(s2); {
    //    return s.startsWith(s2);
    //}
    //function endWith(s2); {
    //    return s.endWith(s2);
    //}

    function replace(s2, replacement) {
        return s.replace(new RegExp(s2, 'g'), replacement);
    }
    function match( s2) {
        return s.match(new RegExp(s2, 'g'));
    }

    function upperFirst(s2) {
        return s2.trim().toUpperCase().replace(s2[0], s2[0].toUpperCase());
    }

    function lowerFirst(s2) {
        return s2.trim().toLowerCase().replace(s2[0], s2[0].toUpperCase());
    }

  //  try {
    return {
        origin: s,
            //charAt: charAt,
            //concat: concat,
            //splite: splite,
            //indexOf: indexOf,
            //includes: includes,
            //lastIndexOf: lastIndexOf,
            //substring: substring,
            //subLength: subLength,
            //slice: slice,
            //startsWith: startsWith,
            //endWith: endWith,
            //length: s.length,
            replace: replace,
            match: match,
            upperFirst: upperFirst,
            lowerFirst: lowerFirst
        }
 //   } catch (e) {
 //       return e;
//    }
}
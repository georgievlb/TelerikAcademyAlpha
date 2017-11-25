function LexicographicalComparison(array) {
    var charArray1 = [];
    for (var i = 0; i < array[0].length; i++) {
        charArray1[i] = array[0].charAt(i);
    }
    var charArray2 = [];
    for (var i = 0; i < array[1].length; i++) {
        charArray2[i] = array[1].charAt(i);
    }
    //return charArray2;




    var length = 0;
    if (charArray1.length < charArray2.length) {
        length = charArray2.length;
    }
    else if (charArray1.length > charArray2.length) {
        length = charArray1.length;
    }
    else if (charArray1.length == charArray2.length) {
        length = charArray1.length;
    }

    var result = [];

    for (var i = 0; i < length; i++) {
        // if (charArray2[i] === undefined) {
        //     break;
        // }

        if (charArray1[i] < charArray2[i]) {
            result[0] = "<";
        }
        else if (charArray1[i] > charArray2[i]) {
            result[0] = ">";
        }
        else if (charArray1[i] == charArray2[i]) {
            result[0] = "=";
        }
    }

    return result[0];
}
var wtf = LexicographicalComparison(['dogwtf', 'dog']);
console.log(wtf);
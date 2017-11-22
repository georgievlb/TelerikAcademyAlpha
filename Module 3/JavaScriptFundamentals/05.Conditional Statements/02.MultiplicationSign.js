function FindSign(array) {
    var first = parseFloat(array[0]);
    var second = parseFloat(array[1]);
    var third = parseFloat(array[2]);

    if (first == 0 || second == 0 || third == 0) {
        return "0";
    }

    if(first < 0 && second < 0){
        return "-";
    }
    else if(second < 0 && third < 0){
        return "+";
    }
    else if(first < 0 && third < 0){
        return "+";
    }
    else if (first < 0 || second < 0 || third < 0) {
        return "-";
    }
    else {
        return "+"
    }
}
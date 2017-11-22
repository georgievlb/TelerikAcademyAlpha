function FindBiggest(array) {
    var first = parseFloat(array[0]);
    var second = parseFloat(array[1]);
    var third = parseFloat(array[2]);

    if (first > second && first > third){
        return first;
    }
    else if (second > first && second > third){
        return second;
    }
    else{
        return third;
    }
}
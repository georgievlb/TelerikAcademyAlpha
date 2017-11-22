function FindBiggest(array) {
    var first = parseFloat(array[0]);
    var second = parseFloat(array[1]);
    var third = parseFloat(array[2]);
    var fourth = parseFloat(array[3]);
    var fifth = parseFloat(array[4]);

    if (first > second && first > third && first > fourth && first > fifth){
        return first;
    }
    else if (second > first && second > third && second > fourth && second > fifth){
        return second;
    }
    else if(third > first && third > second && third > fourth && third > fifth){
        return third;
    }
    else if(fourth > first && fourth > second && fourth > third && fourth > fifth){
        return fourth;
    }
    else{
        return fifth;
    }
}
function Sort(array) {
    var number1 = parseFloat(array[0]);
    var number2 = parseFloat(array[1]);
    var number3 = parseFloat(array[2]);
    var first = null;
    var second = null;
    var third = null;

    if (number1 > number2 && number1 > number3){
        first = number1;
    }
    else if (number2 > number1 && number2 > number3){
        first = number2;
    }
    else{
        first = number3;
    }

    if (number1 < number2 && number1 < number3){
        third = number1;
    }
    else if (number2 < number1 && number2 < number3){
        third = number2;
    }
    else{
        third = number3;
    }

    if (number1 == number2 || number1 == number3){
        second = number1;
    }
    else if (number2 == number1 || number2 == number3){
        second = number2;
    }
    else{
        second = number3;
    }







    if(number1 != first && number1!= third){
        second = number1;
    }
    else if(number2 != first && number2!= third){
        second = number2;
    }
    else if(number3 != first && number3 != third){
        second = number3;
    }

    if(second == null){
        if(){

        }
    }

    return first + " " + second + " " + third;
}
function Exchange(array){
    var number1 = parseFloat(array[0]);
    var number2 = parseFloat(array[1]);
    var temp = null;
    if (number1.toFixed(1) > number2.toFixed(1)){
        temp = number1;
        number1 = number2;
        number2 = temp;
        return number1 + " " + number2;
    }
    else{
        return number1 + " " + number2;
    }
  }
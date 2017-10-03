function FindDigit(number){
  let mysteriousNumber = number % 1000;
  let thirdDigit = mysteriousNumber / 100;
  
  if(thirdDigit.toFixed(0) == 7){
    return "true";
  }
  else{
      return "false " + thirdDigit.toFixed(0);
    }  
};
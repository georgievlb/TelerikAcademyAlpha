function FindDigit(number){
    function customToFixed(stringValue) {
        stringValue = stringValue.toString().split('.');
        return result = stringValue[0];
    }

  let mysteriousNumber = (number % 1000);
  let thirdDigit = (mysteriousNumber / 100);
    
  if(customToFixed(thirdDigit) == 7){
    return "true";
  }
  else{    
      return "false " + customToFixed(thirdDigit);
    } 
    
};
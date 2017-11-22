function FindBit(number){
 
    var decimalNumber = (number[0] >>> 0).toString(2);

    function customToFixed(stringValue) {
        stringValue = stringValue.toString().split('.');
        return result = stringValue[0];
    }

  let mysteriousNumber = (decimalNumber % 1000);
  let thirdDigit = (mysteriousNumber / 100);
    
    return customToFixed(thirdDigit);
};
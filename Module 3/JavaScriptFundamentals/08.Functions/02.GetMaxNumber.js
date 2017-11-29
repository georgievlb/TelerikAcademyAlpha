function LargestOfThree(input) {
    var stringInput = input.toString();
    var parsedInput = stringInput.split(' ');
    var a = parsedInput[0];
    var b = parsedInput[1];
    var c = parsedInput[2];
    function GetMax(number1, number2) {
        if (number1 > number2) {
            return number1;
        }
        else if (number2 < number1) {
            return number2;
        }
        else {
            return number1;
        }
    }

    var temp = GetMax(a, b);
    var result = GetMax(temp, c);
    console.log("input = " + input);
    console.log("parsed input = " + parsedInput);
    return result;
}
console.log(LargestOfThree([8, 3, 6]));
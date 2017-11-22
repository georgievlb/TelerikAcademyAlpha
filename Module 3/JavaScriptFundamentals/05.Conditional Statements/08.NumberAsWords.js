function NumberAsWords(array) {
    var digits = array[0].split("");
    var first = digits[digits.length - 3];
    var second = digits[digits.length - 2];
    var third = digits[digits.length - 1];

    if (third != null) {
        switch (third) {
            case "0":
                third = "zero";
                break;
            case "1":
                third = "one";
                break;
            case "2":
                third = "two";
                break;
            case "3":
                third = "three";
                break;
            case "4":
                third = "four";
                break;
            case "5":
                third = "five";
                break;
            case "6":
                third = "six";
                break;
            case "7":
                third = "seven";
                break;
            case "8":
                third = "eight";
                break;
            case "9":
                third = "nine";
                break;
            default:
                break;
        }
    }

    switch (first) {
        case "1":
            first = "One hundred ";
            break;
        case "2":
            first = "Two hundred ";
            break;
        case "3":
            first = "Three hundred ";
            break;
        case "4":
            first = "Four hundred ";
            break;
        case "5":
            first = "Five hundred ";
            break;
        case "6":
            first = "Six hundred ";
            break;
        case "7":
            first = "Seven hundred ";
            break;
        case "8":
            first = "Eight hundred ";
            break;
        case "9":
            first = "Nine hundred ";
            break;
        default:
            break;
    }






    switch (second) {
        case "0":
            break;
        case "1":
            switch (second) {
                case "1":
                    second = "eleven";
                    break;
                case "2":
                    second = "twelve";
                    break;
                case "3":
                    second = "thirteen";
                    break;
                case "4":
                    second = "fourteen";
                    break;
                case "5":
                    second = "fifteen";
                    break;
                case "6":
                    second = "sixteen";
                    break;
                case "7":
                    second = "seventeen";
                    break;
                case "8":
                    second = "eighteen";
                    break;
                case "9":
                    second = "nineteen";
                    break;
            }
            break;
        case "2":
            second = "twenty";
            break;
        case "3":
            second = "thirty";
            break;
        case "4":
            second = "fourty";
            break;
        case "5":
            second = "fifty";
            break;
        case "6":
            second = "sixty";
            break;
        case "7":
            second = "seventy";
            break;
        case "8":
            second = "eighty";
            break;
        case "9":
            second = "ninety";
            break;
        default:
            break;
    }

    if (digits.length == 3) {
      if(digits[digits.length - 2] == 0){
        return first + "and " + third;   
      }
      else if(digits[digits.length - 2] != 1){
        return first + "and " + second + " " + third;
        }
      else{
        return first + "and " + second;
      }
    }
    else if (digits.length == 2) {
        return second + " " + third;
    }
    else {
        return third;
    }

}

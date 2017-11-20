function PrimeCheck(array){
    if (array[0] < 0){
        return false;
    }
    else{
        var divider = 2;
        var maxDivider = Math.sqrt(array[0]);
        var isPrime = true;

        while(isPrime && (divider <= maxDivider)){
            if (num % divider == 0){
                prime = false;
                break;
            }
            divider++;
        }
        if(isPrime){
            return true;
        }
        else{
            return false;
        }
    }
}
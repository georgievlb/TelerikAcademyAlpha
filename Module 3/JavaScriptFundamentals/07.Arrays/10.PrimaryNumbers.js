function prime(number){
    var array = [];
    // for(var i = 0; i < number; i++)
    // {
    //     array.push(true);
    // }
    //Math.sqrt(number) is the maximum dividier of number
    for(var i = 2; i <= Math.sqrt(number); i++)
    {
        if(array[i] == undefined){
            for(var j = i * i; j <= number; j += i){
                array[j] = true;
            }
        }
    }

    var result = [];
    for(var i = number; i >= 2; i--){
        if(!array[i]){
            return +i;//add a + so it's not treated as a string
        }
    }
    // for(var i = 2; i < number; i++){
    //     if(array[i] == undefined){ //== true
    //     result.push(i);
    //     }
    // }

    //return result.pop();
}
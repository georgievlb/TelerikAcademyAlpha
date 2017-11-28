function prime(number){
    var array = [];
    for(var i = 0; i <= number; i++)
    {
        array[i] = true;
    }

    for(var i = 2; i < Math.sqrt(number); i++)
    {
        if(array[i] == true){
            for(var j = i * i; j < number;){
                array[j] = false;
            }
        }
    }


    return array;
}
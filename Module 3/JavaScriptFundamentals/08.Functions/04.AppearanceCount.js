function AppearanceCount(input){
    var arraySize = input[0];
    var arrayOfNumbers = input[1].split(' ');
    var searchedValue = input[2];
    var counter = 0;

    for(var i = 0; i < arraySize; i++){
        if(arrayOfNumbers[i] == searchedValue){
            counter++;
        }
    }
    return arrayOfNumbers;
}
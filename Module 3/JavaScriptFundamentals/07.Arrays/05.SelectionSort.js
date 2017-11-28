function selectionSort(input) {
    var array = input.splice(1, input.length);

    for (var i = 0; i < array.length - 1; i++) {

        var smallestIndex = i;

        for (var j = i + 1; j < array.length; j++) {
            if (array[j] < array[smallestIndex]) {
                smallestIndex = j;
            }
        }
        if (smallestIndex != i) {
            var temp = array[i];
            array[i] = array[smallestIndex];
            array[smallestIndex] = temp;
        }

    }

    for(var i = 0; i < array.length; i++){
        console.log(array[i]);
    }
}

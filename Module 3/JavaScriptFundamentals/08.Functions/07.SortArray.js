function arraySort(input) {
    var arraySize = +input[0];
    var arrayToSort = input[1].split(' ');

    function selectionSort(input) {
        var array = input;

        for (var i = 0; i < array.length - 1; i++) {

            var smallestIndex = i;

            for (var j = i + 1; j < array.length; j++) {
                if (+array[j] < +array[smallestIndex]) {
                    smallestIndex = j;
                }
            }
            if (smallestIndex != i) {
                var temp = array[i];
                array[i] = array[smallestIndex];
                array[smallestIndex] = temp;
            }

        }

        return array;
    }
    var result = selectionSort(arrayToSort);
    return result.join(' ');
}


//sorting negative numbers should be done after they are parsed as numbers!
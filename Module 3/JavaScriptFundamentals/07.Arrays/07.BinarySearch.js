function outer(array) {
    var numberOfElements = array.splice(0, 1);
    var itemToFind = array.splice(array.length - 1, array.length - 1);

    function BinarySearch(array, value) {
        if (array.length == 0) {
            return -1;
        }

        return BinarySearchRecursive(value, 0, numberOfElements - 1, array);
    }


    function BinarySearchRecursive(number, minIndex, maxIndex, sortedArray) {
        if (minIndex > maxIndex) {
            return -1;
        }

        var midIndex = parseInt((minIndex + maxIndex) / 2);
        var midNumber = sortedArray[midIndex];

        if (number == midNumber) {//make sure you return the first occurrence of the item to find
            // //return "The index of " + number + " is " + midIndex;
            // var firstOccurrence = midIndex;
            // if (firstOccurrence !== null) {
            //     return firstOccurrence;
            // }
            // else {
            //     return midIndex;
            // }
            return midIndex;
        }

        if (midNumber < number) {
            minIndex = midIndex + 1;
        }
        else {
            maxIndex = midIndex - 1;
        }

        return BinarySearchRecursive(number, minIndex, maxIndex, sortedArray);
    }

    function cut(array) {
        array.slice(0, 1);

        return array;
    }

    return BinarySearch(array, itemToFind);
}
console.log(outer(['10', '1', '2', '4', '8', '16', '31', '32', '64', '65', '77', '99', '32']));
function MaximumIncreasingSequence(array) {
    var tempNumber = array[0];
    var tempSequence = 1;
    var maximumSequenceLength = 1;
    for (var i = 1; i < array.length; i++) {
        if (tempNumber < array[i]) {
            tempSequence++;
        }
        else {
            tempSequence = 1;
        }
        tempNumber = array[i];
        if (maximumSequenceLength < tempSequence) {
            maximumSequenceLength = tempSequence;
        }
    }
    return maximumSequenceLength;
}
console.log(MaximumIncreasingSequence(['8', '7', '3', '2', '3', '4', '2', '2', '4']));
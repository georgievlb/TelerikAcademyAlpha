function LargerThanNeighbours(input) {
    var arraySize = +input[0];
    var array = input[1].split(' ');
    var counter = 0;
    var isLarger = false;
    for (var i = 1; i < arraySize - 1; i++) {
        var current = i
        var previous = i - 1;
        var next = i + 1;
        if ((+array[current] > +array[previous]) && (+array[current] > +array[next])) {
            isLarger = true;
            return i;
        }
    }
    if (!isLarger) {
        return -1;
    }
}
console.log(LargerThanNeighbours(['6', '-26 -25 -28 31 2 27']));
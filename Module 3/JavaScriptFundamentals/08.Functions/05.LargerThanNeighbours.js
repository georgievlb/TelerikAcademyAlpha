function LargerThanNeighbours(input) {
    var arraySize = +input[0];
    var array = input[1].split(' ');
    var counter = 0;
    for (var i = 1; i < arraySize - 1; i++) {
        var current = i
        var previous = i - 1;
        var next = i + 1;
        if ((+array[current] > +array[previous]) && (+array[current] > +array[next])) {

            counter++;
        }
    }

    return counter;
}
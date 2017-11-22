function Matrix(n) {
    var array1 = [];
    var numberToFill = 0;
    for (var rows = 0; rows < n; rows++) {
        numberToFill = rows;
        array1[rows] = [0];   //must be defined to create a new row on each iteration        
        for (var cols = 0; cols < n; cols++) {
            array1[rows][cols] = numberToFill + 1;
            numberToFill++;
        }
        console.log((array1[rows]).join(' '));
    }
}
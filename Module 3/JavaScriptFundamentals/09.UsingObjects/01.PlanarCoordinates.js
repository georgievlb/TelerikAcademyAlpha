// var array = [1, 2, 3];

// Array.prototype.showSize = function(){
//   console.log(this.length);
// }
// array.showSize();

// var array2 = ['1', 'book'];
// array2.showSize();
//this refers to the object on which you will call the function, not on the prototype!
// console.log(Array.getPrototypeOf(array2) == Array);
//this is how you get the prototype of an object in production code
function PlanarCoordinates(input) {

    var point1 = {
        x: +input[0],
        y: +input[1],
    }
    var point2 = {
        x: +input[2],
        y: +input[3],
    }
    var point3 = {
        x: +input[4],
        y: input[5],
    }
    var point4 = {
        x: +input[6],
        y: +input[7],
    }
    var point5 = {
        x: +input[8],
        y: +input[9],
    }
    var point6 = {
        x: +input[10],
        y: +input[11],
    }

    var line1 = {
        A: point1,
        B: point2,
    }
    var line2 = {
        A: point3,
        B: point4,
    }
    var line3 = {
        A: point5,
        B: point6,
    }

    function getDistance(line) {
        var x1 = line.A.x;
        var x2 = line.B.x;
        var y1 = line.A.y;
        var y2 = line.B.y;
        var distance = Math.sqrt(
            (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)
        )

        return distance;
    }

    var distance1 = (getDistance(line1));
    var distance2 = (getDistance(line2));
    var distance3 = (getDistance(line3));
    var isTriangle = false;

    console.log(distance1.toFixed(2) + "\n" + distance2.toFixed(2) + "\n" + distance3.toFixed(2))

    if ((distance1 + distance2 > distance3) &&
        (distance1 + distance3 > distance2) &&
        (distance2 + distance3 > distance1)) {
        isTriangle = true;
    }

    if (isTriangle) {
        return "Triangle can be built";
    }
    else {
        return "Triangle can not be built"
    }
}

var input = ['5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12'];


PlanarCoordinates(input);
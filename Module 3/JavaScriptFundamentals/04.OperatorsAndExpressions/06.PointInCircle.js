function PointInCircle(array){
    var xcoord = array[0];
    var ycoord = array[1];
    var xcenter = 0;
    var ycenter = 0;
    var radius = 2;
    var temp = (xcoord - xcenter) * (xcoord - xcenter) + 
        (ycoord - ycenter) * (ycoord - ycenter);
    var distance = Math.sqrt(temp);
    if(distance <= radius){
        return ("yes " + distance.toFixed(2));
    }
    else
    return ("no" + distance.toFixed(2));
}


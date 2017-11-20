function PointInCircle(array){
    var xcoord = parseFloat(array[0]);
    var ycoord = parseFloat(array[1]);
    var xcenter = 0;
    var ycenter = 0;
    var radius = 2;
    var distance = Math.sqrt((xcoord - xcenter) * (xcoord - xcenter) + 
        (ycoord - ycenter) * (ycoord - ycenter));
    
    if(distance <= radius){
        return ("yes " + distance.toFixed(2));
    }
    else
    return ("no " + distance.toFixed(2));
}


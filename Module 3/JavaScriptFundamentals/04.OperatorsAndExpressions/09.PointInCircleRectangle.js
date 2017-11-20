function PointCR (array){
    var xcoord = parseFloat(array[0]);
    var ycoord = parseFloat(array[1]);
    var xcenter = 1;
    var ycenter = 1;
    var radius = 1.5;
    var distance = Math.sqrt((xcoord - xcenter) * (xcoord - xcenter) + (ycoord - ycenter) * (ycoord - ycenter));
    var isInCircle = distance <= radius; 
        
    var isiNRectangle = xcoord >= -1 && xcoord <= 5 && 
    ycoord >= -1 && ycoord <= 1; // check if the point are in the rectangle

    if(isInCircle && isInRectangle){
        return "inside circle inside rectangle"
    }
    else if(isInCircle && !isInRectangle){
        return "inside circle outside rectangle"
    }
    else if(!isInCircle && isInRectangle){
        return "outside circle inside rectangle"
    }
    else {
        return "outside circle outisde rectangle"
    }
}
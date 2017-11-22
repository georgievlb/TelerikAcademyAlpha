function QuadraticEquation(array){
    var a = array[0];
    var b = array[1];
    var c = array[2];
    var discriminant = (b * b) - (4 * a * c);
    if(discriminant < 0){
        return "no real roots";
    }
    else if(discriminant == 0){
        var x = -(b / (2 * a));
        return "x1=x2=" + x.toFixed(2);
    }
    else{
        var x1 = (-b - Math.sqrt(discriminant))/ (2 * a);
        var x2 = (-b + Math.sqrt(discriminant))/ (2 * a);

        return "x1=" + x1.toFixed(2) + "; " + "x2=" + x2.toFixed(2);
    }
}
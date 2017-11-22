function MMSA(array){
    var newArray = parseFloat(array);
    newArray = array.sort();
    
      var sum = 0;
      for(var i = 0; i < array.length; i++){
          sum += parseFloat(array[i]);
      }
      sum = sum.toFixed(2);
    
      var avg = (parseFloat(sum / array.length)).toFixed(2);
  
    
      var min = (parseFloat(array[0])).toFixed(2);
    
      var max = (parseFloat(array[array.length-1])).toFixed(2);
    
      return "min=" + min + "\n" + "max=" + max + "\n" + "sum=" + sum + "\n" + "avg=" + avg;
      
  }
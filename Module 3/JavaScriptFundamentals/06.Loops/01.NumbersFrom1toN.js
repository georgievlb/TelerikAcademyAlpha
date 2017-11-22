function From1ToN(array){
    var number = array[0];
    var stringArray = [null];
    for(var i = 0; i <= number; i++){
        stringArray[i] = i;
    }
  stringArray.splice(0, 1);
  return stringArray.join(' ');
}
console.log(From1ToN(['5']));
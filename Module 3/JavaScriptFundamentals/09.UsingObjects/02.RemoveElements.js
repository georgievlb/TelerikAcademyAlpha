Array.prototype.Remove = function (numberToRemove) {
    for(var i = 0; i < this.length; i++){
        if(this[i] === numberToRemove){
            this.splice(i, 1);
        }
    }
    console.log(this.toString());
    return this;
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
RemoveElements(arr, 1);
console.log(arr);
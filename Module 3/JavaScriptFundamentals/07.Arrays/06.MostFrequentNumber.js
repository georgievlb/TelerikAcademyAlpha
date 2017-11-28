function MostFrequentNumber(input) {
    var array = input.splice(1, input.length);
    array = array.sort();
    var timesNumberAppeared = 0;
    var MaxTimesNumberAppeared = 0;
    var number = array[0];
    var tempNumber = number;
    for (var i = 0; i < array.length; i++) {

        tempNumber = array[i];
        timesNumberAppeared = 0;

        for (var j = i; j < array.length; j++) {
            if (tempNumber == array[j]) {
                timesNumberAppeared++;
            }

            if (MaxTimesNumberAppeared < timesNumberAppeared) {
                MaxTimesNumberAppeared = timesNumberAppeared;
                number = tempNumber;
            }
        }
    }
    return number + " (" + MaxTimesNumberAppeared + " times" + ")";
}
console.log(MostFrequentNumber(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']));
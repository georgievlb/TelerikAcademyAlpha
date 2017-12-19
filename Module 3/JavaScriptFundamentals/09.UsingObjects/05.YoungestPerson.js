function YoungestPerson(input) {

    function ParseInput(input) {
        var people = [];

        for (var i = 0; i < input.length; i += 3) {
            people.push(new Person(input[i], input[i + 1], input[i + 2]));
        }

        function Person(firstName, lastName, age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        return people;
    }

    var arrayOfPeople = ParseInput(input);

    function FindYoungestPerson(arrayOfPeople) {
        //remove magic number
        var youngestAge = 12200;
        var youngestPerson = null;
        for(var i = 0; i < arrayOfPeople.length; i++){
            if(arrayOfPeople[i].age < youngestAge){
                youngestAge = arrayOfPeople[i].age;
                youngestPerson = arrayOfPeople[i];
            }
        }
        for (person in arrayOfPeople){
            
        }

        for (person of arrayOfPeople){
            
        }

        arrayOfPeople.forEach();

    

        return youngestPerson;
    }
    var result = FindYoungestPerson(arrayOfPeople);

    return result.firstName + ' ' + result.lastName;
    
}

var input = ['Gosho', 'Petrov', '32', 'Bay', 'Ivan', '81', 'John', 'Doe', '42'];
console.log(YoungestPerson(input));
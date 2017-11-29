function SayHello(name) {
    //name = prompt('Please enter your name: ');

    if (name != null) {
        return ("Hello, " + name + "!");
    }
}

console.log(SayHello());

// document.getElementById("userInput")
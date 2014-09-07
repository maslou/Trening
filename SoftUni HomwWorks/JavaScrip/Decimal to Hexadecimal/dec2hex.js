
do {
    var inputNum = prompt("Enter a Number");
    if (inputNum != null) {
        var output = Number(inputNum).toString(16).toUpperCase();
        if (output == "NAN") {
            alert("Input is Not a Number")
        }
        else {
            alert(output);
        }
    }
} while (inputNum != null);
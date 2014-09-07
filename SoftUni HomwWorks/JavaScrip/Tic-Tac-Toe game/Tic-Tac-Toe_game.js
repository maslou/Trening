var playF = document.getElementById("play-field");
var collectionCells = playF.getElementsByTagName("img");
CurrTurn = 0;
function setImgAllCellsByCellTitle(colectionCell) {
    for (var i = 0; i < colectionCell.length; i++) {
        var currElTitle = colectionCell[i].title;
        var src = "";
        switch (currElTitle) {
            case "Red player": src = "img/red.png";
                break;
            case "Blue player": src = "img/blue.png";
                break;
            default: src = "img/empty.png";

        }
        colectionCell[i].src = src;
    }
}
function setCellTitleImage(e) {
    currPlayer = "Red";
    if ((CurrTurn % 2)==0) {
        currPlayer = "Blue";
    }
    
    var currTitle = e.title;
    if (currTitle == "No player") {
        if (currPlayer == "Blue") {
            e.title = "Blue player";
            e.src = "img/blue.png";
        }
        else {//red player
            e.title = "Red player";
            e.src = "img/red.png";
        }
        CurrTurn++;
        //setImgAllCellsByCellTitle(collectionCells);
    }
}

function checkColectionEquilTitle(colection) {
    if (colection[0].title == "No player") {
        return "NO";
    }
    if ((colection[0].title == colection[1].title) && (colection[1].title == colection[2].title)) {
        return colection[0].title;
    }
    else {
        return "NO";
    }
}
function checkResults() {
    //check rows
    var result = "";
    var ColectionRow = document.getElementById("play-field").getElementsByTagName("tr");
    for (var i = 0; i < ColectionRow.length; i++) {
        var coleCurRowCell = ColectionRow[i].getElementsByTagName("img");
        result = checkColectionEquilTitle(coleCurRowCell);
        if (result!="NO") {
            alert("AND THE WINNER ISssss: " + result.toString().toUpperCase());
            location.reload();
            break;
        }
    }
    if (result != "NO") {
        return;
    }
    //columhs
    for (var i = 1; i < 4; i++) {
        var currCol = "col" + i;
        var currColectCol = document.getElementById("play-field").getElementsByClassName(currCol);
        result = checkColectionEquilTitle(currColectCol);
        if (result != "NO") {
            alert("AND THE WINNER ISssss: " + result.toString().toUpperCase());
            location.reload();
            break;
        }
    }
    if (result != "NO") {
        return;
    }
    //diagonals
    var colDiag = [document.getElementById("r1c1"), document.getElementById("r2c2"), document.getElementById("r3c3")];
    result = checkColectionEquilTitle(colDiag);
    if (result != "NO") {
        alert("AND THE WINNER ISssss: " + result.toString().toUpperCase());
        location.reload();
        return;
    }

    var colDiag = [document.getElementById("r1c3"), document.getElementById("r2c2"), document.getElementById("r3c1")];
    result = checkColectionEquilTitle(colDiag);
    if (result != "NO") {
        alert("AND THE WINNER ISssss: " + result.toString().toUpperCase());
        location.reload();
        return;
    }
    //check even result
    if (CurrTurn==9) {
        var colectAllCell = document.getElementsByTagName("td");
        var isEvenRes = true;
        for (var i = 0; i < colectAllCell.length; i++) {
            if (colectAllCell[i] == "No player") {
                isEvenRes=false;
            break;
            }    
        }
        if (isEvenRes) {
            alert("GAME OVER WITHOUT WINNER!");
            location.reload();
            return;
        }
    }
}

setImgAllCellsByCellTitle(collectionCells);

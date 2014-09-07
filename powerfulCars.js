function convertKWtoHP(kW) {
    var constHP = 1.34102209;
    return (constHP * kW).toFixed(2);
}

console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));
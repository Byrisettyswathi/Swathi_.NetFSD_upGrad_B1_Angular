var numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];


var unique = [];
for (var i = 0; i < numbers.length; i++) {
    if (!unique.includes(numbers[i])) {
        unique.push(numbers[i]);
    }
}
console.log("Unique Numbers:", unique);


var temp = unique.slice();
temp.sort(function(a, b) {
    return b - a;
});
var secondLargest = temp[1];
console.log("Second Largest:", secondLargest);


var arr = [1, 2, 3, 5, 6];
var missing = 0;
for (var j = 1; j <= 6; j++) {
    if (!arr.includes(j)) {
        missing = j;
    }
}
console.log("Missing Number:", missing);
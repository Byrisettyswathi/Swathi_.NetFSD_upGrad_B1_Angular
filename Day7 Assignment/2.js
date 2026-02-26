let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Mokshi", marks: 45 },
  { name: "Karan", marks: 30 }
];

let pass = students.filter(function(s) {
  return s.marks >= 40;
});
console.log(pass);

let dist = students.filter(function(s) {
  return s.marks >= 85;
});
console.log(dist);

let avg = students.reduce(function(sum, s) {
  return sum + s.marks;
}, 0) / students.length;
console.log(avg);

let topper = students.sort(function(a, b) {
  return b.marks - a.marks;
})[0];
console.log(topper);

let failCount = students.filter(function(s) {
  return s.marks < 40;
}).length;
console.log(failCount);

let grades = students.map(function(s) {
  let g;
  if (s.marks >= 85) g = "A";
  else if (s.marks >= 60) g = "B";
  else if (s.marks >= 40) g = "C";
  else g = "Fail";
  return { name: s.name, grade: g };
});
console.log(grades);
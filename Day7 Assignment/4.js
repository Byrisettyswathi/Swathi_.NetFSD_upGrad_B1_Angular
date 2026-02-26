let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalSalary = employees.reduce(function(sum, e) {
  return sum + e.salary;
}, 0);
console.log(totalSalary);

let high = employees.sort(function(a, b) {
  return b.salary - a.salary;
})[0];
console.log(high);

let hike = employees.map(function(e) {
  if (e.dept === "IT") {
    return { id: e.id, name: e.name, dept: e.dept, salary: e.salary * 1.15 };
  }
  return e;
});
console.log(hike);

let sortedEmp = employees.sort(function(a, b) {
  return b.salary - a.salary;
});
console.log(sortedEmp);
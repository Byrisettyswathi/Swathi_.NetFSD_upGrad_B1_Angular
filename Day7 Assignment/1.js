let books = [
  { id: 1, title: "JavaScript", price: 450, stock: 10 },
  { id: 2, title: "React", price: 650, stock: 5 },
  { id: 3, title: "Node", price: 550, stock: 8 },
  { id: 4, title: "CSS", price: 300, stock: 12 }
];

let titles = books.map(function(b) {
  return b.title;
});
console.log(titles);

let total = books.reduce(function(sum, b) {
  return sum + (b.price * b.stock);
}, 0);
console.log(total);

let above500 = books.filter(function(b) {
  return b.price > 500;
});
console.log(above500);

let increase = books.map(function(b) {
  return { id: b.id, title: b.title, price: b.price * 1.05, stock: b.stock };
});
console.log(increase);

let sorted = books.sort(function(a, b) {
  return a.price - b.price;
});
console.log(sorted);

let removed = books.filter(function(b) {
  return b.id !== 2;
});
console.log(removed);

let out = books.some(function(b) {
  return b.stock === 0;
});
console.log(out);
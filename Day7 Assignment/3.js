let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

let totalCart = cart.reduce(function(sum, item) {
  return sum + (item.price * item.qty);
}, 0);
console.log(totalCart);

let updateQty = cart.map(function(item) {
  if (item.id === 2) {
    return { id: item.id, product: item.product, price: item.price, qty: item.qty + 1 };
  }
  return item;
});
console.log(updateQty);

let removeItem = cart.filter(function(item) {
  return item.id !== 3;
});
console.log(removeItem);

let discount = cart.map(function(item) {
  if (item.price > 10000) {
    return { id: item.id, product: item.product, price: item.price * 0.9, qty: item.qty };
  }
  return item;
});
console.log(discount);

let costly = cart.some(function(item) {
  return item.price > 50000;
});
console.log(costly);

let stock = cart.every(function(item) {
  return item.qty > 0;
});
console.log(stock);
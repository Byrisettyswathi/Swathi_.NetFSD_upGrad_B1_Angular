create database Assignment2
use Assignment2

CREATE TABLE customers (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50)
);

INSERT INTO customers VALUES
(1,'John','Smith'),
(2,'Emma','Watson'),
(3,'David','Miller'),
(4,'Sophia','Brown');



CREATE TABLE orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    order_status INT
);

INSERT INTO orders VALUES
(101,1,'2024-01-10',1),
(102,2,'2024-02-12',4),
(103,3,'2024-03-05',2),
(104,4,'2024-04-01',1);

select c.first_name, c.last_name,o.order_id,o.order_date,o.order_status
from customers c inner join orders o
on c.customer_id = o.customer_id
where o.order_status in (1,4)
order by o.order_date desc;


select * from orders
select * from customers



CREATE TABLE brands (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(50)
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(50)
);

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2)
);

INSERT INTO brands VALUES
(1,'Nike'),
(2,'Adidas'),
(3,'Puma');

INSERT INTO categories VALUES
(1,'Shoes'),
(2,'Clothing'),
(3,'Accessories');

INSERT INTO products VALUES
(101,'Running Shoes',1,1,2023,800),
(102,'Sports T-Shirt',2,2,2022,600),
(103,'Training Shoes',3,1,2024,950),
(104,'Cap',2,3,2023,300),
(105,'Jacket',1,2,2024,1200);

select p.product_name,b.brand_name,c.category_name,p.model_year,p.list_price
from products p inner join categories c
on p.category_id = c.category_id join brands b
on p.brand_id = b.brand_id
where p.list_price > 500
order by list_price asc

CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100),
    brand_id INT,
    category_id INT,
    model_year INT,
    list_price DECIMAL(10,2)
);


CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100)
);

CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT
);

CREATE TABLE order_items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT
);

INSERT INTO stores VALUES
(1,'Hyderabad Store'),
(2,'Bangalore Store');

INSERT INTO stocks VALUES
(1,101,20),
(1,102,35),
(1,103,15),
(2,101,10),
(2,102,25),
(2,105,30);

INSERT INTO order_items VALUES
(1,201,101,2),
(2,202,102,1),
(3,203,101,3),
(4,204,103,2);

select p.product_name,st.store_name , sk.quantity as available_stock, sum(oi.quantity) as total_quantity_sold
from products p inner join stocks sk
on p.product_id= sk.product_id inner join stores st
on st.store_id = sk.store_id left join order_items oi
on sk.product_id = oi.product_id
group by p.product_name, st.store_name,sk.quantity
order by product_name asc

;



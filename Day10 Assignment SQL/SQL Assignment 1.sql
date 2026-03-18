use Assignment

create table worker (
worker_id int primary key identity(1,1),
first_name varchar(30),
last_name varchar(20),
salary int,
joining_date datetime,
department char(25)
);


create table bonus(
worker_ref_id int,
bonus_amount int,
bonus_date datetime,
foreign key (worker_ref_id) references worker(worker_id)
on delete cascade
);


create table title(
worker_ref_id int,
worker_title char(25),
affected_from datetime,
foreign key(worker_ref_id) references worker(worker_id)
on delete cascade
);


insert into worker values
('Monika', 'Arora', '100000', '2014-02-20', 'HR');

select * from worker

insert into worker values
('Niharika', 'Verma', '80000', '2014-06-11', 'ADMIN'),
('Vishal', 'Singhal', '300000', '2014-02-20', 'HR'),
('Amitabh', 'Singh', '500000', '2014-02-20', 'ADMIN'),
('Vivek', 'Bhati', '500000', '2014-06-11', 'ADMIN'),
('Vipul', 'Diwan', '200000', '2014-06-11', 'ACCOUNT'),
('Satish', 'Kumar', '75000', '2014-01-20', 'ACCOUNT'),
('Geethika', 'Chauhan', '90000', '2014-04-11', 'ADMIN');


INSERT INTO Bonus (WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE) VALUES
(1, 5000, '2016-02-20 00:00:00'),
(2, 3000, '2016-06-11 00:00:00'),
(3, 4000, '2016-02-20 00:00:00'),
(1, 4500, '2016-02-20 00:00:00'),
(2, 3500, '2016-06-11 00:00:00');

INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
(1, 'Manager', '2016-02-20'),
(2, 'Executive', '2016-06-11'),
(8, 'Executive', '2016-06-11'),
(5, 'Manager', '2016-06-11'),
(4, 'Asst. Manager', '2016-06-11'),
(7, 'Executive', '2016-06-11'),
(6, 'Lead', '2016-06-11'),
(3, 'Lead', '2016-06-11');


ALTER TABLE Bonus
ALTER COLUMN BONUS_DATE DATE;


select * from title



-------Question--------


select first_name as worker_name
from worker;

select upper(first_name) as Worker_name  --to make lower to upper letters
from worker;

select distinct(department)     ---to get unique departments
from worker;

SELECT substring(first_name, 1, 3) as first_name ------to get the first threee characters from name
from Worker;

select charindex('a' , first_name)
from worker                                -----to find the position number of a
where First_name = 'amitabh';

SELECT rtrim(FIRST_NAME)
FROM Worker;

SELECT ltrim(department)
FROM Worker;


---if i want to remove middle use replace(first_name,' ','')---------



select distinct(department),len(DEPARTMENT) AS DEPT_LENGTH    --to find the length of department names
 from worker


 select replace(first_name, 'a', 'A') 
 from worker
 

 select first_name + ' ' + last_name as complete_name    ---to add firstname and last name in single column
 from worker;

 select * from worker 
 order by first_name asc;

 
 select * from worker 
 order by first_name asc,department desc;


 select * from worker
 where first_name in ('Vipul','Satish'); ---we use "in" to get 2 names

 select * from worker
 where first_name not in ('Vipul','Satish');

 select * from worker
 where department ='Admin';

 select * from worker
 where first_name like '%a%';   ---containing "a" in the first name

  select * from worker
 where first_name like '%a';       --whose first name ends with a


   select * from worker
 where first_name like '______h';  -----ends with h and contains 6 characters


  select * from worker
 where salary between 100000 and 500000; 

SELECT *
FROM Worker
WHERE MONTH(JOINING_DATE) = 2
AND YEAR(JOINING_DATE) = 2014;

select first_name,salary from worker
where salary >= 50000 and salary <=100000;

select department,count(*) as total_workers from worker
group by department
order by total_workers desc;




SELECT  GETDATE() as currentdate;
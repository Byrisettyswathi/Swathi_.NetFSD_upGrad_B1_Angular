use practice
select datediff(yy,'2002-05-03', getdate()) as age;
select datediff(mm,'2002-05-03', getdate()) as age_in_months;
select datename(weekday,'2002-05-03') as week_name;


select datename(weekday,'2002-05-20') as week_name;
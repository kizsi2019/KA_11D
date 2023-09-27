SELECT Avg(standard_cost) FROM `products` ;
SELECT Avg(standard_cost) FROM `products`  where list_price < 30;
SELECT Avg(standard_cost) FROM `products`  where category = 'Sauces';
SELECT Sum(standard_cost) FROM `products` ;
SELECT Sum(standard_cost) FROM `products` where list_price between 20 and 50 ; 
SELECT Sum(standard_cost) FROM `products` where NOT category = 'Sauces'; 

SELECT COUNT(id)  FROM `employees` WHERE city = 'Seattle';
SELECT COUNT(id)  FROM `employees` WHERE job_title = 'Sales Representative';
SELECT COUNT(id)  FROM `employees` WHERE first_name like 'a%';

SELECT min(standard_cost) FROM `products` ;
SELECT max(standard_cost) FROM `products` ;
SELECT standard_cost FROM `products` where list_price >= 30 ;
SELECT standard_cost FROM `products` where product_code like '%CO%' ;

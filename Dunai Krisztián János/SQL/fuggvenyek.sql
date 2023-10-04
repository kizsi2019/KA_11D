SELECT AVG(standard_cost) as atlag
FROM products;

SELECT AVG(standard_cost) as atlag
FROM products
WHERE list_price < 30;

SELECT AVG(standard_cost) as atlag
FROM products
WHERE category = 'Sauces';





SELECT SUM(standard_cost) AS total_cost
FROM products;

SELECT SUM(standard_cost) AS total_cost
FROM products
WHERE list_price >= 20 AND list_price <= 50;

SELECT SUM(standard_cost) AS total_cost
FROM products
WHERE category <> 'Sauces';




SELECT COUNT(*) as employee_count
FROM employees
WHERE city = 'Seattle';


SELECT COUNT(*) as employee_count
FROM employees
WHERE job_title = 'Sales Representative';

SELECT COUNT(*) as employee_count
FROM employees
WHERE first_name LIKE 'A%';






SELECT MIN(standard_cost) as legkisebb_ertek
FROM products;


SELECT MAX(standard_cost) as legnagyobb_ertek
FROM products;


SELECT MAX(standard_cost) as legnagyobb_ertek
FROM products
WHERE list_price >= 30;

SELECT MAX(standard_cost) as legnagyobb_ertek
FROM products
WHERE product_code LIKE '%CO%';

1,
SELECT AVG(standard_cost) FROM products;

SELECT AVG(standard_cost) FROM products WHERE list_price < 30;

SELECT AVG(standard_cost) FROM products WHERE LIKE category "%Sauces%";



2,
SELECT SUM(standard_cost) FROM products;

SELECT SUM(standard_cost) FROM products WHERE list_price BETWEEN 20 AND 50;

SELECT SUM(standard_cost) FROM products WHERE category <> 'Sauces';



3,
SELECT COUNT(id) FROM employees WHERE City = 'Seattle';

SELECT COUNT(id) FROM employees WHERE job_title = 'Sales Representative';

SELECT COUNT(id) FROM employees WHERE first_name LIKE 'A%';



4,
SELECT MIN(standard_cost) AS legkisebb_ertek FROM products;

SELECT MAX(standard_cost) AS legnagyobb_ertek FROM products;

SELECT MAX(standard_cost) AS legnagyobb_ertek FROM products WHERE list_price >= 30;

SELECT MAX(standard_cost) AS legnagyobb_ertek FROM products WHERE product_code LIKE '%CO%';









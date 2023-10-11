1,a
SELECT AVG(standard_cost) FROM products;
a
SELECT AVG(standard_cost) FROM products WHERE list_price < 30;
c
SELECT AVG(standard_cost) FROM products WHERE LIKE category "%Sauces%";



2,a
SELECT SUM(standard_cost) FROM products;
b
SELECT SUM(standard_cost)FROM products WHERE list_price BETWEEN 20 and 50;
c
SELECT SUM(standard_cost) FROM products WHERE NOT category = 'Sauces';


3,a

SELECT COUNT(ID) FROM employees WHERE City = 'Seattle';
b
SELECT COUNT(ID) FROM employees WHERE job_title = 'Sales Representative';
c
SELECT COUNT(ID) FROM employees WHERE first_name LIKE 'A%';






4,a
SELECT MIN(standard_cost) AS LEGKISEBB FROM products;
b
SELECT MAX(standard_cost) AS LEGNAGYOBB FROM products;
c
SELECT MAX(standard_cost) FROM products WHERE list_price >= 30;
d,
SELECT MAX(standard_cost) FROM products WHERE product_code LIKE %CO%;
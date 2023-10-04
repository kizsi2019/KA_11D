
SELECT AVG(standard_cost) FROM products;
SELECT AVG(standard_cost) FROM products WHERE list_price < 30;
SELECT AVG(standard_cost) FROM products WHERE category <> "Sauces";

SELECT SUM(standard_cost) FROM products;
SELECT SUM(standard_cost) FROM products WHERE list_price BETWEEN 20 AND 50;
SELECT SUM(standard_cost) FROM products WHERE NOT category <> "Sauces";

SELECT id FROM employees WHERE city = "Seattle";
SELECT id, job_title FROM employees WHERE job_title = "Sales Representative";
SELECT id, first_name FROM employees WHERE first_name LIKE "A%";


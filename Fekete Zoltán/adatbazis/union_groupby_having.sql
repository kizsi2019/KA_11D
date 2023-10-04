1.
SELECT ship_state_province FROM orders
UNION
SELECT state_province FROM customers

SELECT ship_state_province FROM orders
UNION ALL
SELECT state_province FROM customers

2.
SELECT COUNT(id) FROM products
GROUP BY category

3.
SELECT COUNT(id) FROM orders
GROUP BY ship_city

4.
SELECT COUNT(id) FROM customers
HAVING COUNT(id) >= 3
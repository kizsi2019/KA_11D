SELECT DISTINCT ship_state_province FROM orders
UNION ALL
SELECT DISTINCT state_province FROM customers;

SELECT COUNT(id) FROM products
GROUP BY category
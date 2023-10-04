1. Feladat

SELECT DISTINCT ship_state_province
FROM orders
UNION ALL
SELECT DISTINCT state_province
FROM customers;

2. Feladat

SELECT category, COUNT(*) as product_count
FROM products
GROUP BY category;


3. Feladat

SELECT ship_city, COUNT(*) as order_count
FROM orders
GROUP BY ship_city;



4. Feladat

SELECT ship_city, COUNT(*) as customer_count
FROM customers
GROUP BY ship_city
HAVING COUNT(*) >= 3;


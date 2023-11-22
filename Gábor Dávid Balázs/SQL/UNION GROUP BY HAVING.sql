1.
a)
SELECT ship_state_province
FROM orders
UNION

b)
SELECT state_province FROM customers
UNION ALL

2.
SELECT COUNT(category)
FROM products
GROUP BY category

3.
SELECT COUNT(ship_city)
FROM orders
GROUP BY ship_city

4.
SELECT COUNT(ID), country_region
FROM Customers
GROUP BY City
HAVING COUNT(ID) >= 3
ORDER BY COUNT(ID) DESC;
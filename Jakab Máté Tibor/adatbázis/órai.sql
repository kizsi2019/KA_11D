1
Select ship_state_Province FROM order;
UNION
SELECT state_Province FROM customers;

b
Select ship_state_Province FROM order;
UNION ALL
SELECT state_Province FROM customers;

2
SELECT Count(ID) FROM 'products';
GROUP BY Category;

3
SELECT Category, COUNT(*) AS rendeles_szam
FROM orders
GROUP BY ship_city;

4
SELECT city, COUNT(*) AS ugyfel_szam
FROM customers
GROUP BY city
HAVING COUNT(*)

1. a SELECT ship_state_province FROM orders
UNION
SELECT state_province FROM customers

1.b SELECT ship_state_province FROM orders
UNION ALL
SELECT state_province FROM customers

2.SELECT COUNT(ID) FROM products 
GROUP BY category 

3. SELECT COUNT(ship_city) FROM orders

4. SELECT COUNT(customerID) FROM customers group by city having COUNT(customerID) >= 3;
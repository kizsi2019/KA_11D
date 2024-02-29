SELECT ship_state_province FROM Orders UNION SELECT state_province from Customers;
SELECT ship_state_province FROM Orders UNION ALL SELECT state_province from Customers;
select count(CategoryID) from products;
select count(ship_city) from Orders;
SELECT count(id) from customers having count(id) >= 3;
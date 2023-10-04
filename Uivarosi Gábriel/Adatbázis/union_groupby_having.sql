SELECT ship_state_province FROM Orders
union all
Select state_province from Customers;
Select COUNT(CategoryID) FROM Products;
SELECT COUNT(ship_city) as 'Város' FROM `orders`; 
SELECT COUNT(	CustomerID) as 'Ügyfelek' FROM `customers` GROUP BY city HAVING COUNT(	CustomerID) >= 3;
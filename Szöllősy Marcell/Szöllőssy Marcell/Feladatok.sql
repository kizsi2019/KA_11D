SELECT SupplierName, Country FROM Suppliers WHERE Country LIKE USA, UK;

SELECT SupplierName, Country FROM Suppliers WHERE Country = 'USA' AND City = 'Boston' OR 'New Orleans';

SELECT SupplierName, Country FROM Suppliers WHERE Not Country = 'Japan' or 'Canada';

SELECT * FROM Products ORDER BY ProductName, Price ASC;

SELECT * FROM Products ORDER BY ProductName, Price DSC;

SELECT * FROM Products ORDER BY ProductName ASC, Unit DSC;
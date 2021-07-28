SELECT Name AS Customers
FROM Customers
LEFT JOIN Orders ON Customers.Id = CustomerId
WHERE CustomerId IS NULL;

SELECT Name AS Customers
FROM Customers
WHERE Customers.Id NOT IN
(
    SELECT customerid FROM orders
);
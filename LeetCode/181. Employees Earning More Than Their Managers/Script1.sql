/*
SELECT e1.Name as Employee 
FROM Employee e1 
JOIN Employee e2 
WHERE e1.ManagerId = e2.Id AND e1.Salary > e2.Salary;
*/
SELECT emp.Name as Employee 
FROM Employee emp 
INNER JOIN Employee manager ON emp.ManagerId = manager.Id
WHERE emp.Salary > manager.Salary;
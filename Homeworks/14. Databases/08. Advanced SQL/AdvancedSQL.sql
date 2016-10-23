USE TelerikAcademy

-- 1.Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
-- Use a nested SELECT statement.

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

-- 2.Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName, LastName, Salary
FROM Employees
WHERE 
	Salary > (SELECT MIN(Salary) FROM Employees) AND
	Salary <= (SELECT MIN(Salary)*1.1 FROM Employees)

-- 3.Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
-- Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName as [FullName], e.Salary, d.Name as[DepartmentName]
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE e.Salary = 
  (SELECT MIN(Salary) FROM Employees 
   WHERE DepartmentID = d.DepartmentID)
ORDER BY e.Salary

-- 4.Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) as[Avg Salary]
FROM Employees
WHERE DepartmentID = 1

-- 5.Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(Salary) as [Avg Salary]
FROM Employees e
 JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 6.Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(EmployeeID) as [Number of employees]
FROM Employees e
 JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

-- 7.Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(EmployeeID) as [Number of employees]
FROM Employees e
WHERE e.ManagerID IS NOT Null

-- 8.Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(EmployeeID) as [Number of employees]
FROM Employees e
WHERE e.ManagerID IS Null

-- 9.Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name as [Department Name], AVG(Salary) as [Avg Salary]
FROM Employees e
 JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 10.Write a SQL query to find the count of all employees in each department and for each town.


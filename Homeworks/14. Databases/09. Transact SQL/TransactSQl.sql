-- 1.Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.

USE [master]
GO

CREATE DATABASE PesonsAccount
GO

USE PesonsAccount

CREATE TABLE Persons
(
	PersonID int IDENTITY,
	FirstName varchar(30) NOT NULL,
	LastName varchar(30) NOT NULL,
	SSN varchar(10) NOT NULL,
	CONSTRAINT PK_Persons PRIMARY KEY(PersonID)
)
GO

CREATE TABLE Accounts(
	AccountID int IDENTITY NOT NULL PRIMARY KEY,
	PersonId int NOT NULL,
	Balance money NOT NULL
	CONSTRAINT FK_Accounts_Persons FOREIGN KEY(AccountID)
	REFERENCES Persons(PersonID)
)
GO

INSERT INTO Persons(FirstName, LastName, SSN)
VALUES
	('Pesho', 'Peshev', 6912063456),
	('Asen', 'Ivanov', 7003022313),
	('Gosho', 'Goshev', 7301016789),
	('Mimi', 'Pesheva', 8904056789)

INSERT INTO Accounts(PersonId, Balance)
VALUES
	(1, 2500.45),
	(2, 1456.25),
	(3, 1234.78),
	(4, 678.40)

CREATE PROC dbo.usp_FullNames
AS
  SELECT FirstName + ' ' + LastName AS [Full Name] 
  FROM Persons
GO

EXEC usp_FullNames

-- 2.Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROC dbo.usp_DalanceAccountAboveThreshold
	(@balanceThreshold money = 700)
AS
  SELECT p.FirstName, p.LastName, a.Balance
  FROM Persons p
	INNER JOIN Accounts a
		ON p.PersonID = a.AccountID
  WHERE a.Balance > @balanceThreshold
GO

EXEC usp_DalanceAccountAboveThreshold

-- 3.Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum.
--Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_CalculateInterest(@balance money, @yearInterest float, @months int)
	RETURNS money
AS
BEGIN
	RETURN @balance + @balance * (@yearInterest / 12) * @months
END

SELECT p.FirstName, p.LastName, a.Balance, dbo.ufn_CalculateInterest(Balance, 10, 12) AS [Current Balance]
FROM Accounts a
	INNER JOIN Persons p
		ON p.PersonID = a.AccountID

-- 4.Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
-- It should take the AccountId and the interest rate as parameters.

CREATE PROCEDURE [dbo].[usp_InterestPerMonthPerPerson](
@accountId int, @interestRate float)
AS
DECLARE @balance money = 
(SELECT Balance FROM Accounts WHERE AccountID = @accountId)

SELECT Balance, dbo.ufn_CalculateInterest(Balance, @interestRate, 1)- @balance AS [Current Interest]
FROM Accounts
WHERE AccountID = @accountId
GO

EXEC usp_InterestPerMonthPerPerson 3, 12

--5.	Add two more stored procedures `WithdrawMoney(AccountId, money)` and `DepositMoney(AccountId, money)` that operate in transactions.

CREATE PROCEDURE [dbo].[usp_WithdrawMoney](@accountId int, @money money)
AS
BEGIN
	UPDATE Accounts
	SET Balance -=@money
	WHERE AccountID = @accountId
	END
GO

EXEC usp_WithdrawMoney 3, 100

CREATE PROCEDURE [dbo].[usp_DepositMoney](@accountId int, @money money)
AS
BEGIN
	UPDATE Accounts
	SET Balance +=@money
	WHERE AccountID = @accountId
	END
GO

EXEC usp_DepositMoney 3, 500


--6.	Create another table – `Logs(LogID, AccountID, OldSum, NewSum)`.
--	*	Add a trigger to the `Accounts` table that enters a new entry into the `Logs` table every time the sum on an account changes.

CREATE TABLE Logs(
	LogID int IDENTITY PRIMARY KEY,
	AccountID int NOT NULL,
	OldSum money,
	NewSum money,
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountID)
	REFERENCES Accounts(AccountID)
)
GO

CREATE TRIGGER tr_AccountUpdate ON Accounts FOR UPDATE
AS
INSERT INTO Logs(AccountID, OldSum, NewSum)
SELECT i.Id, d.Balance, i.Balance
FROM inserted i, deleted d
GO

EXEC usp_WithdrawMoney 3, 100

EXEC usp_DepositMoney 4, 500

--7.	Define a function in the database `TelerikAcademy` that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
--	*	_Example_: '`oistmiahf`' will return '`Sofia`', '`Smith`', … but not '`Rob`' and '`Guy`'.

use TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName(
@nameToCheck NVARCHAR(50), 
@letters NVARCHAR(50))
RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i, 1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO

CREATE FUNCTION dbo.ufn_AllEmploeeysAndTownByStringCondition(@format nvarchar(50))
RETURNS @table TABLE
	([Name] nvarchar(50) NOT NULL)
AS
BEGIN
	INSERT @table
	SELECT newTbl.LastName FROM
		(SELECT LastName FROM Employees
		UNION
		SELECT Name FROM Towns) as newTbl
		WHERE dbo.ufn_CheckName(newTbl.LastName, @format) > 0
	 RETURN
END
GO

SELECT * FROM ufn_AllEmploeeysAndTownByStringCondition('oiseltmiahf')

--8.	Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT e.FirstName, e.LastName, t.Name FROM Employees e
  JOIN Addresses a
  ON e.AddressID = a.AddressID
  JOIN Towns t
  ON a.TownID = t.TownID

OPEN empCursor
DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @town nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
  			  DECLARE empCursor1 CURSOR READ_ONLY FOR
			  SELECT e.FirstName, e.LastName, t.Name FROM Employees e
			  JOIN Addresses a
			  ON e.AddressID = a.AddressID
			  JOIN Towns t
			  ON a.TownID = t.TownID

			OPEN empCursor1
			DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
			FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1

			WHILE @@FETCH_STATUS = 0
			  BEGIN
			  IF(@town=@town1 AND @firstName != @firstName1 AND @lastName != @lastName1)
				  BEGIN
					PRINT @town+':'+ @firstName + ' ' + @lastName + ':' + @firstName1 + ' ' + @lastName1 
				  END
				FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1
			  END

			CLOSE empCursor1
			DEALLOCATE empCursor1

    FETCH NEXT FROM empCursor  INTO @firstName, @lastName, @town
  END

CLOSE empCursor
DEALLOCATE empCursor


--9.	*Write a T-SQL script that shows for each town a list of all employees that live in it.
--	*	_Sample output_:	
--```sql
--Sofia -> Martin Kulov, George Denchev
--Ottawa -> Jose Saraiva
--…
--```

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT DISTINCT t.Name, t.Name AS [fullNames] FROM Towns t

OPEN empCursor
DECLARE @town nvarchar(50), @fullNames nvarchar(2000)
FETCH NEXT FROM empCursor INTO @town, @fullNames

WHILE @@FETCH_STATUS = 0
  BEGIN
  			  DECLARE empCursor1 CURSOR READ_ONLY FOR
			  SELECT e.FirstName, e.LastName, t.Name FROM Employees e
			  JOIN Addresses a
			  ON e.AddressID = a.AddressID
			  JOIN Towns t
			  ON a.TownID = t.TownID

			OPEN empCursor1
			DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
			FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1

			WHILE @@FETCH_STATUS = 0
			  BEGIN
			  IF(@town=@town1)
				  BEGIN
					SET @fullNames+= @firstName1 + ' ' + @lastName1 + ', ' 
				  END
				FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1
			  END
			  
			CLOSE empCursor1
			DEALLOCATE empCursor1
		PRINT @town + ' -> '+ @fullNames
    FETCH NEXT FROM empCursor INTO @town, @fullNames
  END

CLOSE empCursor
DEALLOCATE empCursor
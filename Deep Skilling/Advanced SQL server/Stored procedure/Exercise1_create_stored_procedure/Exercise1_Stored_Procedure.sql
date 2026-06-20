USE EmployeeManagementSystem;
GO

--------------------------------------------------
-- Get Employee Details By Department
--------------------------------------------------

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

--------------------------------------------------
-- Execute Procedure
--------------------------------------------------

EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
GO

--------------------------------------------------
-- Insert Employee Procedure
--------------------------------------------------

CREATE PROCEDURE sp_InsertEmployee
    @EmployeeID INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @EmployeeID,
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO

--------------------------------------------------
-- Execute Insert Procedure
--------------------------------------------------

EXEC sp_InsertEmployee
    @EmployeeID = 5,
    @FirstName = 'Aditi',
    @LastName = 'Kumari',
    @DepartmentID = 3,
    @Salary = 80000,
    @JoinDate = '2025-06-20';
GO

--------------------------------------------------
-- Verify Data
--------------------------------------------------

SELECT * FROM Employees;
GO
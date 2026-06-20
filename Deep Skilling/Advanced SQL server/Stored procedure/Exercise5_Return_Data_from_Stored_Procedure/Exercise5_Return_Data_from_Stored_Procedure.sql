USE EmployeeManagementSystem;
GO

--------------------------------------------------
-- Return Total Employees in Department
--------------------------------------------------

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        DepartmentID,
        COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID
    GROUP BY DepartmentID;
END;
GO

--------------------------------------------------
-- Execute Procedure
--------------------------------------------------

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 3;
GO
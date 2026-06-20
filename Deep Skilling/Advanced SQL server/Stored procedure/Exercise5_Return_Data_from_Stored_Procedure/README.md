# Exercise 5 - Return Data from a Stored Procedure

## Goal

Create a stored procedure that returns the total number of employees in a department.

## Procedure Name

sp_GetEmployeeCountByDepartment

## Parameter

@DepartmentID INT

## SQL Concepts Used

- CREATE PROCEDURE
- Parameters
- COUNT()
- GROUP BY
- EXEC

## Example

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 3;

## Output

DepartmentID | TotalEmployees
------------ | --------------
3            | 2
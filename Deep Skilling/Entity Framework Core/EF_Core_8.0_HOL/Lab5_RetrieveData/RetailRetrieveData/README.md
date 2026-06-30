# EF Core 8.0 - Lab 5: Retrieving Data from the Database

## Objective

Retrieve records from SQL Server using Entity Framework Core.

## Technologies Used

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server Express
- Visual Studio Code

## Methods Used

- ToListAsync()
- FindAsync()
- FirstOrDefaultAsync()

## Commands

```bash
dotnet new console -n RetailRetrieveData

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet build

dotnet run

## Ouput
Display all products
Find a product by ID
Retrieve the first product with price greater than ₹5000
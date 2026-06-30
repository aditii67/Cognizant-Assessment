# EF Core 8.0 - Lab 4: Inserting Initial Data into the Database

## Objective

Insert initial data into SQL Server using Entity Framework Core.

## Technologies

- C#
- .NET 8
- EF Core 8
- SQL Server Express
- VS Code

## Commands Used

```bash
dotnet new console -n RetailInsertData

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet build

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet run
```

## Output

Successfully inserted:

- Electronics
- Groceries
- Laptop
- Rice Bag
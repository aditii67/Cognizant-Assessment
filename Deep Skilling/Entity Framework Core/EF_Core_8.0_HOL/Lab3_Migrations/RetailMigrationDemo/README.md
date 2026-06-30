# EF Core 8.0 - Lab 3: Using EF Core CLI to Create and Apply Migrations

## Objective
Learn how to use EF Core CLI to generate migrations and create a SQL Server database.

## Technologies Used
- C#
- .NET 8
- Entity Framework Core 8
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Visual Studio Code

## Commands Used

```bash
dotnet new console -n RetailMigrationDemo

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet build

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet run
```

## Output
- Migration created successfully.
- RetailMigrationDB created successfully.
- Categories and Products tables created.
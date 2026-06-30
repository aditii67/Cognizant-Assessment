# EF Core 8.0 - Lab 2: Setting Up the Database Context

## Objective

Configure Entity Framework Core DbContext and connect a .NET Console Application to SQL Server.

## Technologies

- C#
- .NET 8
- Entity Framework Core 8
- SQL Server Express
- VS Code

## Project Structure

```
RetailStoreDbContext
│
├── Models
│   ├── Category.cs
│   └── Product.cs
│
├── Data
│   └── AppDbContext.cs
│
├── Migrations
├── Program.cs
├── appsettings.json
└── README.md
```

## Commands Used

```bash
dotnet new console -n RetailStoreDbContext
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

## Output

- Connected to SQL Server.
- Created RetailStoreDB.
- Applied EF Core migration successfully.
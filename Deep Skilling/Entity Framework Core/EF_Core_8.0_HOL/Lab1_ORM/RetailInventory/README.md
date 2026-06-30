# EF Core 8.0 - Lab 1: Understanding ORM with a Retail Inventory System

## Objective

This hands-on exercise demonstrates how Entity Framework Core 8.0 (EF Core) works as an Object-Relational Mapper (ORM) by connecting C# classes with SQL Server database tables.

---

## Scenario

A retail store wants to build an inventory management system to manage:

- Products
- Categories
- Stock Levels

EF Core is used to create and manage the database without writing SQL queries manually.

---

## Technologies Used

- C#
- .NET 8 Console Application
- Entity Framework Core 8.0
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Visual Studio Code

---

## Project Structure

```
RetailInventory
│
├── Models
│   ├── Product.cs
│   └── Category.cs
│
├── Data
│   └── InventoryContext.cs
│
├── Migrations
│
├── Program.cs
│
├── RetailInventory.csproj
│
└── README.md
```

---

## EF Core Packages Installed

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
```

---

## Database Connection

```text
Server=localhost\SQLEXPRESS
Database=RetailInventoryDB
Trusted_Connection=True
TrustServerCertificate=True
```

---

## Commands Used

### Create Project

```bash
dotnet new console -n RetailInventory
```

### Install Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Build Project

```bash
dotnet build
```

### Create Migration

```bash
dotnet ef migrations add InitialCreate
```

### Update Database

```bash
dotnet ef database update
```

### Run Project

```bash
dotnet run
```

---

## Output

- Successfully created the RetailInventoryDB database.
- Applied the InitialCreate migration.
- Created the following tables:
  - Categories
  - Products
  - __EFMigrationsHistory

---

## Learning Outcomes

- Understood the concept of ORM.
- Learned how EF Core maps C# classes to SQL Server tables.
- Configured a DbContext.
- Created database migrations.
- Generated a SQL Server database using EF Core.
- Connected a .NET console application with SQL Server.

---
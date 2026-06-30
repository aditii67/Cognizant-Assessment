using RetailMigrationDemo.Data;

Console.WriteLine("==================================");
Console.WriteLine(" EF Core CLI Migration Demo");
Console.WriteLine("==================================");

using var db = new AppDbContext();

Console.WriteLine("Database Context Created Successfully!");
Console.WriteLine("Ready to Apply Migrations.");
using RetailStoreDbContext.Data;

Console.WriteLine("================================");
Console.WriteLine(" Retail Store DbContext Demo");
Console.WriteLine("================================");

using var db = new AppDbContext();

Console.WriteLine("Database Context Created Successfully.");
Console.WriteLine("Connected to SQL Server.");
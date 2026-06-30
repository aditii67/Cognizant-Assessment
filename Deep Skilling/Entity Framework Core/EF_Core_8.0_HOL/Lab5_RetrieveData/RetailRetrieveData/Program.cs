using Microsoft.EntityFrameworkCore;
using RetailRetrieveData.Data;

using var context = new AppDbContext();

Console.WriteLine("========== All Products ==========");

var products = await context.Products.ToListAsync();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

Console.WriteLine();

Console.WriteLine("========== Find By ID ==========");

var product = await context.Products.FindAsync(1);

Console.WriteLine($"Found : {product?.Name}");

Console.WriteLine();

Console.WriteLine("========== First Product Price > 5000 ==========");

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 5000);

Console.WriteLine($"Expensive : {expensive?.Name}");
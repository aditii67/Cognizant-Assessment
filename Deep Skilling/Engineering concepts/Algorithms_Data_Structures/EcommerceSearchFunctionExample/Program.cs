using EcommerceSearchFunctionExample.Models;
using EcommerceSearchFunctionExample.Services;

namespace EcommerceSearchFunctionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Headphones", "Electronics")
            };

            Console.WriteLine("===================================");
            Console.WriteLine(" E-COMMERCE PLATFORM SEARCH ");
            Console.WriteLine("===================================");

            Console.WriteLine("\nAvailable Products:");

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.Write("\nEnter Product Name to Search: ");

            string? searchName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(searchName))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("\n----- LINEAR SEARCH -----");

            Product? linearResult =
                SearchService.LinearSearch(products, searchName);

            if (linearResult != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine(linearResult);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Product[] sortedProducts =
                products.OrderBy(p => p.ProductName).ToArray();

            Console.WriteLine("\n----- BINARY SEARCH -----");

            Product? binaryResult =
                SearchService.BinarySearch(sortedProducts, searchName);

            if (binaryResult != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine(binaryResult);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

using EcommerceSearchFunctionExample.Models;

namespace EcommerceSearchFunctionExample.Services
{
    public class SearchService
    {
        // Linear Search
        public static Product? LinearSearch(Product[] products, string target)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(target,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }

            return null;
        }

        // Binary Search
        public static Product? BinarySearch(Product[] products, string target)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int compareResult =
                    string.Compare(
                        products[mid].ProductName,
                        target,
                        StringComparison.OrdinalIgnoreCase);

                if (compareResult == 0)
                {
                    return products[mid];
                }

                if (compareResult < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }
    }
}
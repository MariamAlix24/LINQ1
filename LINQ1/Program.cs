using LINQ.DataSources;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            var seafoodproduct = Source.ProductList.Where(p => p.Category == "Seafood")
            .Select(p => new { p.ProductName, p.UnitPrice });
            foreach (var product in seafoodproduct)
            {
                Console.WriteLine(product);
            }
            //Q2
            var productNames = Source.ProductList
            .Select(p => p.ProductName)
            .ToList();
            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }
            //Q3
            var sortedProducts = Source.ProductList
            .OrderBy(p => p.UnitPrice)
            .Select(p => new { p.ProductName, p.UnitPrice });
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }
            //Q4
            var productsInRange = Source.ProductList
           .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var product in productsInRange)
            {
                Console.WriteLine(product);
            }
            //Q5
            var filteredProducts = Source.ProductList
           .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            foreach (var product in filteredProducts)
            {
                Console.WriteLine(product);
            }
            //Q6
            var result = Source.ProductList
           .Select(p => new
           {
               Name = p.ProductName,
               Price = p.UnitPrice,
               StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
           });
            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }
    }
}

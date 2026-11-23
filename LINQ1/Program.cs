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
        }
    }
}

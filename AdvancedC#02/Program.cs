namespace AdvancedC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new() {


            new Product {Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10},
            new Product {Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product {Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product {Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product {Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product {Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80},
            new Product {Id=7, Name="C# Book",Category = "Books",Price=45,Stock = 30 },
            new Product {Id=8, Name="Novel", Category = "Books", Price=20, Stock = 60 },
            new Product {Id=9, Name="Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            new Product {Id=10,Name="Jacket", Category = "Clothing", Price = 120, Stock = 15 } };

            #region Task01
            //Console.WriteLine("--- Electronics ---");
            //var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
            //foreach (var p in electronics)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}(Stock:{p.Stock})");
            //}


            //Console.WriteLine("\n=== Under $50 ===");
            //var cheap = SearchProducts(catalog, p => p.Price < 50);
            //foreach (var p in cheap)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}(Stock:{p.Stock})");
            //}


            //Console.WriteLine("\n=== In Stock ===");
            //var stock = SearchProducts(catalog, p => p.Stock > 0);
            //foreach (var p in stock)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}(Stock:{p.Stock})");
            //}

            //Console.WriteLine("\n=== Clothing Under $100 ===");
            //var clothing = SearchProducts(catalog, p => p.Price < 100 && p.Category == "Clothing");
            //foreach (var p in clothing)
            //{
            //    Console.WriteLine($"{p.Name} - ${p.Price}(Stock:{p.Stock})");

            //}
            #endregion


        }
        #region Task01
        //public static List<Product> SearchProducts(List<Product> catalog, Func<Product, bool> filter)
        //{
        //    List<Product> results = new() { };

        //    foreach (var p in catalog)
        //    {
        //        if (filter(p))
        //            results.Add(p);

        //    }
        //    return results;
        //}
        #endregion




    }
}

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


            #region Task02
            //Console.WriteLine("--- Short Report ---");
            //PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            //Console.WriteLine("\n--- Detailed Report ---");
            //PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}")); 
            #endregion


            #region Task03
            //Console.WriteLine("--- Summary List ---");
            //var summary = TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
            //foreach(var s in summary)
            //{
            //    Console.WriteLine(s);
            //}


            //Console.WriteLine("\n--- Price Labels ---");
            //var label = TransformProducts(catalog, p => p.Price > 100 ? "Expensive!" : "Affordable");
            //for (int i = 0; i < catalog.Count; i++)
            //{
            //    Console.WriteLine($"{catalog[i].Name}: {label[i]}");
            //} 
            #endregion

            #region Task04
            //Console.WriteLine("--- Low-Stock Alert ---");
            //var filter = FilterProducts(catalog, p => p.Stock < 20);
            //foreach(var p in filter)
            //{
            //    Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");
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

        #region Task02
        //public static void PrintReport(List<Product> catalog, Action<Product> action)
        // {
        //     foreach (var p in catalog)
        //     {
        //         action(p);
        //     }
        // } 
        #endregion

        #region Task03
        //public static List<T> TransformProducts<T>(List<Product> catalog , Func<Product , T> fun)
        //{
        //    List<T> results = new List<T>();
        //    foreach(var p in catalog)
        //    {
        //        results.Add(fun(p));
        //    }
        //    return results;



        //} 
        #endregion

        #region Task04
        //public static List<Product> FilterProducts(List<Product> catalog, Predicate<Product> predi)
        //{

        //    List<Product> results = new List<Product>();
        //    foreach(var p in catalog)
        //    {
        //        if (predi(p))
        //            results.Add(p);
        //    }
        //    return results;

        //} 
        #endregion



    }
}

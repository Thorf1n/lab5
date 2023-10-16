namespace Lab5
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var store = new Store();


            var product1 = new Product { Name = "Laptop", Price = 1000, Description = "Gaming laptop", Category = "Electronics", Rating = 4.5 };
            var product2 = new Product { Name = "Book", Price = 20, Description = "Interesting book", Category = "Books", Rating = 3.9 };
            var product3 = new Product { Name = "Camera", Price = 800, Description = "Professional camera", Category = "Electronics", Rating = 4.7 };


            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);


            var searchResult = store.SearchByCriteria("Electronics", 0, 1000);

            foreach (var product in searchResult)
            {
                Console.WriteLine("Found product:");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"Description: {product.Description}");
                Console.WriteLine($"Category: {product.Category}");
                Console.WriteLine($"Rating: {product.Rating}");
                Console.WriteLine();
            }
        }
    }
}

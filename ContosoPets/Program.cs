using System;
using System.Linq;
using ContosoPets.Data;

namespace ContosoPets
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new ContosoPetsContext();

            /*
            var squeakyBone = new Product
            {
                Name = "Squeaky Dog Bone",
                Price = 4.99M
            };
            context.Products.Add(squeakyBone);
            
            var tennisBalls = new Product
            {
                Name = "Tennis Ball 3-Pack",
                Price = 9.99M
            };
            context.Add(tennisBalls);

            context.SaveChanges();
            */
            
            var products = context.Products
                .Where(p => p.Price >= 5.00M)
                .OrderBy(p => p.Name);

            foreach (var product in products)
            {
                Console.WriteLine($"Id:\t{product.Id}");
                Console.WriteLine($"Name:\t{product.Name}");
                Console.WriteLine($"Price:\t{product.Price:C2}");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
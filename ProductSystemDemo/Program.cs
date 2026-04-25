using System;

namespace ProductSystemDemo
{
    class Program
    {
        static void Main()
        {
            Product p1 = new Product("Laptop");

            Product p2 = new Product("Phone", 8500);

            Product p3 = new Product("Tablet", 6500, 10);

            Console.WriteLine("Product 1 Details:");
            p1.DisplayProduct();

            Console.WriteLine("\nProduct 2 Details:");
            p2.DisplayProduct();

            Console.WriteLine("\nProduct 3 Details:");
            p3.DisplayProduct();
        }
    }
}
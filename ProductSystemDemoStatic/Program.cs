using System;


namespace ProductSystemDemoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.StoreName);

            double discount = Product.CalculateDiscount(1000);

            Console.WriteLine($"Discount = {discount}");

            Product p = new Product("Laptop", 15000, 5);

            p.DisplayProduct();
        }
    }
}
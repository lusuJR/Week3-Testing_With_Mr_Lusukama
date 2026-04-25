using System;

namespace ProductSystemDemoWith_TestingUnit 
{ 
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price (press ENTER to skip): ");
            string priceInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(priceInput))
            {
                Product p = new Product(name);
                Console.WriteLine(p.DisplayProduct());
                return;
            }

            double price;

            while (!double.TryParse(priceInput, out price))
            {
                Console.Write("Invalid price. Enter again: ");
                priceInput = Console.ReadLine();
            }

            Console.Write("Enter Quantity (press ENTER to skip): ");
            string quantityInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(quantityInput))
            {
                Product p = new Product(name, price);
                Console.WriteLine(p.DisplayProduct());
                return;
            }

            int quantity;

            while (!int.TryParse(quantityInput, out quantity))
            {
                Console.Write("Invalid quantity. Enter again: ");
                quantityInput = Console.ReadLine();
            }

            Product product = new Product(name, price, quantity);

            Console.WriteLine(product.DisplayProduct());
        }
    }
}
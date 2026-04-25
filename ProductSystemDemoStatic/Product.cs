using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSystemDemoStatic
{
    public class Product
    {
        private string productName;
        private double price;
        private int quantity;

        public static string StoreName = "Selianord Retail";

        public Product(string name, double productPrice, int productQuantity)
        {
            productName = name;
            price = productPrice;
            quantity = productQuantity;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Store: {StoreName}");
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {quantity}");
        }

        public static double CalculateDiscount(double price)
        {
            return price * 0.10;
        }
    }
}

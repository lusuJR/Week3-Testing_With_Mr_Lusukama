namespace ProductSystemDemo
{
    public class Product
    {
        private string productName;
        private double price;
        private int quantity;

        // Constructor 1
        public Product(string name)
        {
            productName = name;
            price = 0;
            quantity = 0;
        }

        // Constructor 2
        public Product(string name, double productPrice)
        {
            productName = name;
            price = productPrice;
            quantity = 0;
        }

        // Constructor 3
        public Product(string name, double productPrice, int productQuantity)
        {
            productName = name;
            price = productPrice;
            quantity = productQuantity;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {quantity}");
        }
    }
}
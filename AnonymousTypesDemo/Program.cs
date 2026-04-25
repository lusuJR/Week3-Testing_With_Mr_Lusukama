Console.WriteLine("===========================Example 1===========================");
//Example 1
var lecturer = new
{
    Name = "Lusukama Selemani",
    Age = 44,
    Major = "Computer Science"
};

Console.WriteLine($"Name: {lecturer.Name}");
Console.WriteLine($"Age: {lecturer.Age}");
Console.WriteLine($"Major: {lecturer.Major}");

Console.WriteLine("===========================Example 2===========================");
//Example 2
var product = new
{
    Id = 101,
    Name = "Laptop",
    Price = 999.99
};

Console.WriteLine($"Product ID: {product.Id}");
Console.WriteLine($"Product Name: {product.Name}");
Console.WriteLine($"Product Price: {product.Price}");

Console.WriteLine("===========================Example 3===========================");
//Example 3
var transaction = new
{
    AccountHolder = "Lusukama",
    Amount = 500,
    TransactionType = "Withdrawal"
};

Console.WriteLine(transaction.AccountHolder);
Console.WriteLine(transaction.Amount);
Console.WriteLine(transaction.TransactionType);
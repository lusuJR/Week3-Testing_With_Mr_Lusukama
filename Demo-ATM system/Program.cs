using System;

namespace Demo_ATM_system
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter account holder name: ");
            string name = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            double balance;

            while (!double.TryParse(Console.ReadLine(), out balance))
            {
                Console.Write("Invalid input. Enter valid amount: ");
            }

            BankAccount account = new BankAccount(name, balance);

            int option;

            do
            {
                Console.WriteLine("\n===== ATM MENU =====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Select option: ");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.Write("Invalid option. Enter a number: ");
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Current Balance: R{account.GetBalance():F2}");
                        break;

                    case 2:
                        Console.Write("Enter deposit amount: ");
                        double depositAmount;

                        while (!double.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.Write("Invalid amount. Enter valid amount: ");
                        }

                        account.Deposit(depositAmount);
                        Console.WriteLine("Deposit successful.");
                        Console.WriteLine($"Updated Balance: R{account.GetBalance():F2}");
                        break;

                    case 3:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawAmount;

                        while (!double.TryParse(Console.ReadLine(), out withdrawAmount))
                        {
                            Console.Write("Invalid amount. Enter valid amount: ");
                        }

                        if (account.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine("Withdrawal successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }

                        Console.WriteLine($"Updated Balance: R{account.GetBalance():F2}");
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the ATM system.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select 1 to 4.");
                        break;
                }

            } while (option != 4);
        }
    }
}
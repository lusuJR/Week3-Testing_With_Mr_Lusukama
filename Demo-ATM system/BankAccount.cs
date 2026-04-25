namespace Demo_ATM_system
{
    public class BankAccount
    {
        private string accountHolder;
        private double balance;

        public BankAccount(string name, double initialBalance)
        {
            accountHolder = name;
            balance = initialBalance;
        }

        public string GetAccountHolder()
        {
            return accountHolder;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }

            return false;
        }
    }
}
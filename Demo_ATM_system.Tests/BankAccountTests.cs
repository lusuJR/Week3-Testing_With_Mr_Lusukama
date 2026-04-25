using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo_ATM_system;

namespace Demo_ATM_system.Tests
{
    [TestClass]
    public class BankAccountTests
    {

        [TestMethod]
        public void Deposit_ShouldIncreaseBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Alex",1000 );

            // Act
            account.Deposit(500);

            // Assert
            Assert.AreEqual(1500, account.GetBalance());
        }


        [TestMethod]
        public void Withdraw_ShouldDecreaseBalance_WhenFundsAvailable()
        {
            // Arrange
            BankAccount account = new BankAccount("Alex", 1000);

            // Act
            bool result = account.Withdraw(300);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(700, account.GetBalance());
        }


        [TestMethod]
        public void Withdraw_ShouldFail_WhenInsufficientFunds()
        {
            // Arrange
            BankAccount account = new BankAccount("Alex", 1000);

            // Act
            bool result = account.Withdraw(1500);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(1000, account.GetBalance());
        }


        [TestMethod]
        public void ATMFlow_DepositThenWithdraw_ShouldReturnCorrectFinalBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("Alex", 1000);

            // Act
            account.Deposit(500);
            account.Withdraw(300);

            // Assert
            Assert.AreEqual(1200, account.GetBalance());
        }

    }
}
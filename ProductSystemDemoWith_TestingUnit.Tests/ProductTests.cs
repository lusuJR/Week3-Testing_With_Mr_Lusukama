using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSystemDemoWith_TestingUnit.Tests
{
    [TestClass]
    public class ProductTests
    {

        [TestMethod]
        public void Constructor_WithNameOnly_ShouldSetDefaults()
        {
            Product product = new Product("Laptop");

            Assert.AreEqual("Laptop", product.GetProductName());
            Assert.AreEqual(0, product.GetPrice());
            Assert.AreEqual(0, product.GetQuantity());
        }


        [TestMethod]
        public void Constructor_WithNameAndPrice_ShouldSetQuantityZero()
        {
            Product product = new Product("Phone", 8500);

            Assert.AreEqual("Phone", product.GetProductName());
            Assert.AreEqual(8500, product.GetPrice());
            Assert.AreEqual(0, product.GetQuantity());
        }


        [TestMethod]
        public void Constructor_WithAllParameters_ShouldSetAllValues()
        {
            Product product = new Product("Tablet", 6500, 10);

            Assert.AreEqual("Tablet", product.GetProductName());
            Assert.AreEqual(6500, product.GetPrice());
            Assert.AreEqual(10, product.GetQuantity());
        }


        [TestMethod]
        public void DisplayProduct_ShouldReturnCorrectText()
        {
            Product product = new Product("Tablet", 6500, 10);

            string result = product.DisplayProduct();

            Assert.AreEqual(
                "Product Name: Tablet, Price: 6500, Quantity: 10",
                result
            );
        }
    }
}

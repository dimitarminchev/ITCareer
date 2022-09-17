using Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicrosoftTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void InitializeAcountWithZeroValue()
        {
            // Arrange & Act
            BankAccount acount = new BankAccount();

            // Assert
            Assert.AreEqual(0m, acount.Amount);
        }

        [TestMethod]
        public void InitializeAcountWithPositiveValue()
        {
            // Arrange & Act
            BankAccount acount = new BankAccount(2000m);

            // Assert
            Assert.AreEqual(2000m, acount.Amount);
        }

        [TestMethod]
        public void InitializeAcountAndSetAmount()
        {
            // Arrange 
            BankAccount acount = new BankAccount();

            // Act
            acount.Amount = 1000m;

            // Assert
            Assert.AreEqual(1000m, acount.Amount);
        }
    }
}
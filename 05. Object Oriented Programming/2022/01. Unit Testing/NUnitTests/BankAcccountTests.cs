using Demo;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void InitializeAcountWithZeroValue()
        {
            // Arrange & Act
            BankAccount acount = new BankAccount();

            // Assert
            Assert.AreEqual(0m, acount.Amount);
        }

        [Test]
        public void InitializeAcountWithPositiveValue()
        {
            // Arrange & Act
            BankAccount acount = new BankAccount(2000m);

            // Assert
            Assert.AreEqual(2000m, acount.Amount);
        }

        [Test]
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
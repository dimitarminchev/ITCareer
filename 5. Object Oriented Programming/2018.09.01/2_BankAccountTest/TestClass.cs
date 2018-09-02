using _1_BankAccount;
using NUnit.Framework;

namespace _2_BankAccountTest
{
    [TestFixture] // Атрибут за клас за компонентно тестване 
    public class BankAccountTests
    {
        [Test] // Тест дали можем да създадем сметка и да я захраним
        public void AccoutnInitilizeWithPositiveValue()
        {
            // Arrange
            BankAccount account = new BankAccount(2000m);

            // Act & Assert
            Assert.AreEqual(2000m, account.Balance);
        }

        [Test] // Тест за внасяне на пари по сметка
        public void DespositShouldAddMoney()
        {
            // Arrange
            BankAccount account = new BankAccount();

            // Act
            account.Deposit(50);

            // Assert
            Assert.IsTrue(account.Balance == 50);
        }
    }
}

using System;
using _1_BankAccount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_BankAccountTests
{
    [TestClass] // Атрибут за клас за компонентно тестване 
    public class BankAccountTests
    {
        [TestMethod] // Тест дали можем да създадем сметка и да я захраним
        public void AccoutnInitilizeWithPositiveValue()
        {
            // Arrange
            BankAccount account = new BankAccount(2000m);

            // Act & Assert
            Assert.AreEqual(2000m, account.Balance);
        }

        [TestMethod] // Тест за внасяне на пари по сметка
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

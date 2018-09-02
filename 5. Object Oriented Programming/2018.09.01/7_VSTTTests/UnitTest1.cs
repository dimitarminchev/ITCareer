using System;
using _6_VSTT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _7_VSTTTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTransferFunds()
        {
            // Arrange
            Account source = new Account();
            Account dest = new Account();

            // Act
            source.Deposit(200M);
            dest.Deposit(150M);
            source.Transfer(dest, 100M);

            // Assert
            Assert.AreEqual(100M, source.Balance);
            Assert.AreEqual(250M, dest.Balance);
        }

        /*     Can You Write Following Unit Tests?
               1. TestDeposit
               2. TestDepositZero
               3. TestDepositNegative
               4. TestWithdraw
               5. TestWithdrawZero
               6. TestWithdrawNegative
               7. TestTransferFunds
               8. TestTransferFundsFromNullAccount
               9. TestTransferFundsToNullAccount
              10. TestTransferFundsSameAccount
        */
    }
}

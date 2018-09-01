using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualStudioTeamTests;

namespace VisualStudioTeamTestsTests
{
    [TestClass] // VSTT [TestClass] vs. NUNIT [TextFixture]
    public class UnitTest1
    {
        [TestMethod] // VSTT [TestMethod] vs. NUNIT [Test]
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
    }

    /* Tasks:
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

using System;
using Xunit;

namespace op15.ConsoleApplication.Tests {
    public class BankAccountTests {
        [Fact]
        public void GivenANewBankAccount_WhenDepositing100_ThenBalanceShouldBe100() {
            //GivenANewBankAccount
            BankAccount b1 = new BankAccount();

            //WhenDepositing100
            b1.Deposit(100);

            //ThenBalanceShouldBe100
            decimal expected = 100;
            decimal actual = b1.Balance;

            Assert.Equal(expected, actual);
        }
    }
}

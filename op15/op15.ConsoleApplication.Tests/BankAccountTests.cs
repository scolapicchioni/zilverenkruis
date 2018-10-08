using System;
using Xunit;

namespace op15.ConsoleApplication.Tests {
    public class BankAccountTests {
        [Fact]
        public void GivenANewBankAccount_WhenDepositing100_ThenBalanceShouldBe100() {
            //GivenANewBankAccount
            BankAccount b1 = new BankAccount("");

            //WhenDepositing100
            b1.Deposit(100);

            //ThenBalanceShouldBe100
            decimal expected = 100;
            decimal actual = b1.Balance;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenANewBankAccount_WhenWithdrawingMoreThanBalance_ThenBalanceShouldBe0() {
            //GivenANewBankAccount
            BankAccount b1 = new BankAccount("");

            //WhenWithdrawingMoreThanBalance
            b1.Withdraw(b1.Balance + 1);

            //ThenBalanceShouldBe0
            decimal expected = 0;
            decimal actual = b1.Balance;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenANewBankAccountWithPositiveBalance_WhenWithdrawingAmountLessThanBalance_ThenBalanceShouldBePreviousBalanceMinusAmount() {
            //GivenANewBankAccountWithPositiveBalance
            BankAccount b1 = new BankAccount("");
            b1.Deposit(100);

            decimal toWithdraw = b1.Balance - 1;
            decimal expected = b1.Balance - toWithdraw;

            //WhenWithdrawingAmountLessThanBalance
            b1.Withdraw(toWithdraw);

            //ThenBalanceShouldBePreviousBalanceMinusAmount
            decimal actual = b1.Balance;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenANewBankAccount_ThenOwnerShouldBeNull() {
            //GivenANewBankAccount
            BankAccount b1 = new BankAccount("");
            
            //ThenOwnerShouldBeNull    
            Assert.Null(b1.Owner);
        }

        [Fact]
        public void GivenANewBankAccountWithAString_ThenTheIdShouldBeSet() {
            //GivenANewBankAccountWithAString
            string givenId = "test_test_123";
            BankAccount b1 = new BankAccount(givenId);

            //ThenTheIdShouldBeSet
            Assert.Equal(givenId, b1.Id);
        }
    }
}

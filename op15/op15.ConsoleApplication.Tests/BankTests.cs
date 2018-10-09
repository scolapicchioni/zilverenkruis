using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace op15.ConsoleApplication.Tests {
    public class BankTests {
        [Fact]
        public void GivenANewBank_WhenOpeningAnAccount_ThenTheIdShouldBeEqualToTheFirstThreeLettersOfTheBankNamePlus1() {
            //GivenANewBank
            Bank b1 = new Bank("test");
            //b1.Name = "test";

            //WhenOpeningAnAccount
            BankAccount account = b1.OpenAccount(1);
            string expected = "tes1";
            string actual = account.Id;
            
            //ThenTheBankAccountIdShouldBeEqualTo
            //TheFirstThreeLettersOfTheBankName
            //Plus1
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenANewBankWithAString_ThenTheNameShouldBeSet() {
            //GivenANewBankAccountWithAString
            string givenName = "test_test_123";
            Bank b1 = new Bank(givenName);

            //ThenTheIdShouldBeSet
            Assert.Equal(givenName, b1.Name);
        }
    }
}

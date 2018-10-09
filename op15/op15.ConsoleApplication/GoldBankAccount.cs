using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class GoldBankAccount : BankAccount {
        public GoldBankAccount(string id) : base(id) {

        }

        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}

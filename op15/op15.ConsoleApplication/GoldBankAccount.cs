using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class GoldBankAccount : BankAccount {
        public GoldBankAccount(string id) : base(id) {

        }

        public override void Withdraw(decimal amount) {
            Balance -= amount;
        }
        //add a double property Interest (get and set)
        public double Interest { get; set; }
    }
}

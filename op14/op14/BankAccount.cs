using System;
using System.Collections.Generic;
using System.Text;

namespace op14 {
    public class BankAccount {
        private Person dingetje;

        public Person Owner {
            get { return dingetje; }
            set { dingetje = value; }
        }

        private decimal balance;

        public decimal Balance {
            get {
                return Balance;
            }
        }

        public void Withdraw(decimal amount) {
            if (amount < 0) {
                throw new InvalidOperationException("Amount cannot be negative!");
            }
            if (amount > balance) {
                amount = balance;
            }
            balance -= amount;
        }

        public void Deposit(decimal amount) {
            if (amount < 0) {
                throw new InvalidOperationException("Amount cannot be negative!");
            }
            balance += amount;
        }

    }
}

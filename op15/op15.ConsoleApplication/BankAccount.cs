using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class BankAccount {

        public BankAccount(string id) {
            Id = id;
        }

        public string Id { get; }

        //private Person owner;
        //public Person Owner {
        //    get { return owner; }
        //    set { owner = value; }
        //}

        public Person Owner { get; set; }

        //private decimal balance;
        public decimal Balance {
            get; private set;
        }

        public void Deposit(decimal amount) {
            Balance += amount;
        }
        
        public void Withdraw(decimal amount) {
            if (amount > Balance)
                amount = Balance;
            Balance -= amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class Bank {
        public Bank(string name) {
            Name = name;
        }

        public string Name { get;  }

        private int counter;
        
        public BankAccount OpenAccount() {
            string id = Name.Substring(0, 3) + ++counter ;
            BankAccount ba = new BankAccount(id);
            return ba;
        }

    }
}

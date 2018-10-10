using System;
using System.Collections.Generic;
using System.Text;

namespace op15.ConsoleApplication {
    public class Bank : Object {
        public Bank(string name) {
            Name = name;
        }

        public string Name { get;  }

        private int counter;
        
        public BankAccount OpenAccount(int type) {
            string id = Name.Substring(0, 3) + ++counter ;
            BankAccount ba;

            if (type == 1) {
                 ba = new BankAccount(id);
            } else {
                ba = new GoldBankAccount(id);
            }
            return ba;
        }

    }
}

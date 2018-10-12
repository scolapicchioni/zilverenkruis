using System;
using System.Collections.Generic;
using System.Text;

namespace op22.ConsoleApplication {
    public class BankAccount {
        public static void IncrementCounter() {
            Counter++;
            //Id = Counter
            //Balance++;
        }

        static BankAccount() { //static constructor
            Counter = 123;
        }

        public BankAccount() {
            IncrementCounter();
            Id = Counter;
        }

        static public int Counter { get; set; }

        public int Id { get; set; }
        public decimal Balance { get; private set; }
        public void Deposit(decimal amount) {
            
            Balance += amount;
        }

        public override string ToString() {
            return $"{Id} - {Balance}";
        }
    }
}

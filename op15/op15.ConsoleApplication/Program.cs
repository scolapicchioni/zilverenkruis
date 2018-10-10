using System;

namespace op15.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            //make a Bank
            Bank rabo = new Bank("Rabobank");
            
            //ask the bank to open an account of type BankAccount
            BankAccount account1 = rabo.OpenAccount(1);
            //withdraw 100 
            account1.Withdraw(100);
            //print the balance
            Console.WriteLine($"The balance of account1 is {account1.Balance}");
            //is the balance negative? why?

            //ask the bank to open an account of type GoldBankAccount
            BankAccount b2 = rabo.OpenAccount(2);
            //withdraw 100 
            b2.Withdraw(100);
            //print the balance
            Console.WriteLine($"The balance of b2 is {b2.Balance}");
            //is the balance negative? why?

            //set the Interest to .4
            ((GoldBankAccount)b2).Interest = .4;
            
            Console.ReadLine();
        }
    }
}

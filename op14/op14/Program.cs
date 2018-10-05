using System;

namespace op14 {
    class Program {
        static void Main(string[] args) {
            Person p1 = new Person();
            p1.Address = "Waterkers 70";
            p1.Name = "Simona";

            p1.Surname = "123456789012345678901234567890123456789012345678901234567890";
            
            //p1.SetSurname("123456789012345678901234567890123456789012345678901234567890");

            //string s = p1.GetSurname();
            if (p1.Surname.Length == 50) {
            //if (p1.GetSurname().Length == 50) {
                    Console.WriteLine("YEYYY!!!");
            } else {
                Console.WriteLine("BUUUUUUUU");
            }

            Console.WriteLine($"{p1.Name} {p1.Surname} works at {p1.Address}");
            

            BankAccount b1 = new BankAccount();

            b1.Owner = p1;

            Console.WriteLine($"The balance of a new Bank Account is {b1.Balance}");
            
            bool playAgain = true;
            do {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("X. Exit");
                Console.Write("Please enter the desired operation: ");
                string input = Console.ReadLine();
                if (input == "1") {
                    Deposit(b1);
                } else if (input == "2") {
                    Withdraw(b1);
                } else {
                    playAgain = false;
                }
            } while (playAgain);

            //b1.Balance = -1234;


            Console.ReadLine();
        }

        private static void Deposit(BankAccount b1) {
            bool deposited = false;
            do {
                try {
                    Console.Write("Please insert an amount to deposit: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    b1.Deposit(amount);
                    Console.WriteLine($"The balance of the Bank Account after Deposit({amount}) is {b1.Balance}");
                    deposited = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (!deposited);
        }

        private static void Withdraw(BankAccount b1) {
            bool withdrawn = false;
            do {
                try {
                    Console.Write("Please insert an amount to withdraw: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    b1.Withdraw(amount);
                    Console.WriteLine($"The balance of the Bank Account after Withdraw({amount}) is {b1.Balance}");
                    withdrawn = true;
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (!withdrawn);
        }
    }
}

using System;
using Simo.UI;
using SomeNamespace;
using Simo.Collections;

namespace op22.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            //Program program = new Program();
            //program.ForEachExample();
            //foreach
            ForEachExample();
            //switch
            SwitchExample();
            x = 10;

            ComparisonExample();

            //Simo.UI.TextBox

            Console.ReadLine();
            Console.ReadLine();
        }

        private static void ComparisonExample() {
            int a = 5;
            int b = 5;

            bool equal = a == b; //yes

            Console.WriteLine(equal);


            a = b;

            b++;

            Console.WriteLine(a);




            BankAccount ba = new BankAccount() { Id = 1 };
            BankAccount bb = new BankAccount() { Id = 1 };

            equal = ba == bb;

            Console.WriteLine(equal);

            bb = ba;

            equal = ba == bb;
            bb.Id = 5;
            Console.WriteLine(ba.Id);


            a = 5;
            Increment(a);
            Console.WriteLine(a);

            ba.Id = 5;
            Increment(ba);
            Console.WriteLine(ba.Id);


            Console.WriteLine(equal);

            DateTime birthday = new DateTime(1974, 2, 15);

            DateTime birthday2 = new DateTime(1974, 2, 15);

            DateTime b3 = DateTime.Now;

            if (birthday == birthday2) {
                Console.WriteLine("same");
            } else {
                Console.WriteLine("NOT");
            }

            ConsoleColor c1 = ConsoleColor.Blue;

            ConsoleColor c2 = c1;

            c1 = ConsoleColor.Cyan;

            string s = new string("hi");
            string s2 = "hi";

            int i = 5;
            bool bbb = true;

            equal = s == s2;



            Digit d1 = new Digit(5);

            Digit d2 = new Digit(5);

            //Digit d3 = 5;

            //int i3 = d3;

            d1 = d2;

            //Digit[] LIST

            Console.WriteLine(birthday);

            Simo.UI.List l1 = new Simo.UI.List();

            Simo.Collections.List l2 = new Simo.Collections.List();

            SomeClass sc = new SomeClass();

        }

        static void Increment(BankAccount parameter) {
            parameter.Id++;
        }

        static void Increment(int parameter) {
            parameter++;
        }

        static int x;

        static void ForEachExample() {
            int[] list = new int[]{ 10,20,11,45,276,34,656,88,3,123};
            foreach (int item in list) {
                Console.WriteLine(item);
            }
            Console.WriteLine(BankAccount.Counter); 
            string[] listOfStrings = new string[] {"Mario", "Luigi", "Wario", "Peach" };

            foreach (string item in listOfStrings) {
                Console.WriteLine(item);
            }

            BankAccount[] accounts = new BankAccount[] {
                new BankAccount() {Id = 1},
                new BankAccount() {Id = 2},
                new BankAccount() {Id = 3}
            };
            foreach (BankAccount item in accounts) {
                item.Deposit(10);
                BankAccount.IncrementCounter();
                Console.WriteLine(item);
            }

            double result = Math.Pow(3, 4);
            int comparison = String.Compare("a", "b", false);
            if (comparison == 0) {
                Console.WriteLine("equal!");
            }
            

            //BankAccount.Counter

            string name = "supercalifragilistiexpialidocius";
            foreach (char letter in name) {
                Console.WriteLine(letter);
            }
        }

        static void SwitchExample() {
            Console.WriteLine("Please enter 1 for add, 2 for subtract, 3 for multiply and 4 for divide");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                //add
            } else if (choice == 2) {
                //subtract
            } else if (choice == 3) {
                //multiply
            } else if (choice == 4) {
                //divide
            } else {
                //insult the user
            }

            switch (choice) {
                case 1:
                    //add
                    Console.WriteLine("you chose 1!");
                    Console.WriteLine("so I'm going to add stuff now...");
                    break;
                case 2:
                    //subtract
                    Console.WriteLine("you chose 2!");
                    Console.WriteLine("so I'm going to subtract stuff now...");
                    break;
                case 3:
                    //multiply
                    Console.WriteLine("you chose 3!");
                    Console.WriteLine("so I'm going to multiply stuff now...");
                    break;
                case 4:
                    //divide
                    Console.WriteLine("you chose 4!");
                    Console.WriteLine("so I'm going to divide stuff now...");
                    break;
                default:
                    //insult the user   
                    Console.WriteLine("MORON!");
                    break;
            }
        }
    }
}

using op28.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public class CalculatorPresenter : AppPresenter<Calculator>{
        public CalculatorPresenter(Phone phone) : base(phone){
        }
        
        private int askNumber(string message) {
            int number=0;
            bool ok = false;
            do {
                Console.Write($"{message}: ");
                try {
                    number = int.Parse(Console.ReadLine());
                    ok = true;
                } catch {
                }
            } while (!ok);
            return number;
        }

        public override void Start() {
            string input; 
            do {
                Console.Clear();
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("X. Exit");
                input = Console.ReadLine();
                switch (input) {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Subtract();
                        break;
                    case "3":
                        Multiply();
                        break;
                    case "4":
                        Divide();
                        break;
                }
            } while (input.ToLower() != "x");
            
        }

        private void Add() {
            int n1 = askNumber("Please insert the first number to add");
            int n2 = askNumber("Please insert the second number to add");

            Console.WriteLine(App.Add(n1, n2));
            Console.ReadLine();
        }

        private void Subtract() {
            int n1 = askNumber("Please insert the first number to subtract");
            int n2 = askNumber("Please insert the second number to subtract");

            Console.WriteLine(App.Subtract(n1, n2));
            Console.ReadLine();
        }

        private void Multiply() {
            int n1 = askNumber("Please insert the first number to multiply");
            int n2 = askNumber("Please insert the second number to multiply");

            Console.WriteLine(App.Multiply(n1, n2));
            Console.ReadLine();
        }

        private void Divide() {
            int n1 = askNumber("Please insert the first number to divide");
            int n2 = askNumber("Please insert the second number to divide");

            Console.WriteLine(App.Divide(n1, n2));
            Console.ReadLine();
        }
    }
}

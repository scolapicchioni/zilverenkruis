using op27.BusinessLogic;
using System;

namespace op27.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Phone phone = new Phone();
            Console.WriteLine(phone.Calculator.Add(3, 2));
            double result = phone.Calculator.Divide(0.0, 0.0);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

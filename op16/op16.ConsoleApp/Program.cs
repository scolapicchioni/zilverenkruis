using op16.BusinessLogic;
using System;

namespace op16.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to our School Management System!");
            Console.WriteLine("What do you want to do today?");
            Course course1 = new Course("C#");
            Console.ReadLine();
        }
    }
}

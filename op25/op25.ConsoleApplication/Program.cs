using System;

namespace op25.ConsoleApplication {
    class Program {
        static void Main(string[] args) {

            print();

            ActionInvoker aliasToInvokePrint = print;

            print();
            aliasToInvokePrint();

            aliasToInvokePrint = SayHi;

            aliasToInvokePrint();

            Person p = new Person();
            aliasToInvokePrint = p.Jump;

            aliasToInvokePrint();

            //aliasToInvokePrint = MethodThatReturnsInInt;
            Console.ReadLine();
        }

        static int MethodThatReturnsInInt() {
            return 5;
        }

        static void SayHi() {
            Console.WriteLine("hi");
        }
        static void print() {
            Console.WriteLine("printing...");
        }
    }
}

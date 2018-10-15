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

            Calculation calc = Subtract;

            int result = calc(3, 4);

            ExecuteAndPrint(calc);

            ExecuteAndPrint(Divide);
            ExecuteAndPrint(Multiply);
            //ExecuteAndPrint(print);
            Console.ReadLine();
        }

        static void ExecuteAndPrint(Calculation calc) {
            Console.Write("First number? ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Second number? ");
            int n2 = int.Parse(Console.ReadLine());

            int res = calc(n1, n2);
            Console.Write($"Result: {res}");
        }

        static int Sum(int a, int b) {
            return a + b;
        }

        static int Subtract(int a, int b) {
            return a - b;
        }
        static int Multiply(int a, int b) {
            return a * b;
        }
        static int Divide(int a, int b) {
            return a / b;
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

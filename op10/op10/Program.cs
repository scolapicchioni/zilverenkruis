using System;

namespace op10 {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10; i++) {
                try {
                    int n = GenerateNumber();
                    Console.WriteLine("The number is " + n);
                } catch (ApplicationException ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadLine();
        }

        static int GenerateNumber() {
            Random generator = new Random();

            int number = generator.Next();

            if (number % 3 == 0) {
                throw new ApplicationException("OMG! IT'S A MULTIPLE OF THREEEEE! " + number);
            }

            return number;
        }

    }
}

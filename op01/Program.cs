using System;

namespace op01
{
    class Program
    {
        static void Main(string[] args)
        {
            //type name

            //numbers
            //integers
            //variable declaration
            int variable1;
            //assignment
            variable1 = ((5 + 3) * 2) / 3 % 2;
            //5 = variable1; nope!!
            Console.Write("variable1: ");
            Console.WriteLine(variable1);
            variable1 = -22;
            Console.WriteLine("variable1: " + variable1);
            System.Console.WriteLine("The max value of an int is: " + int.MaxValue);
            System.Console.WriteLine("The min value of an int is: " + int.MinValue); 
            
            //initialization
            long variable2 = 5;
            System.Console.WriteLine("The max value of long is: " + long.MaxValue);
            System.Console.WriteLine("The min value of long is: " + long.MinValue); 
            
            variable2 = 10;

            short variable3 = 5;
            System.Console.WriteLine("The max value of short is: " + short.MaxValue);
            System.Console.WriteLine("The min value of short is: " + short.MinValue); 
            
            uint variable4 = 5;
            System.Console.WriteLine("The max value of an uint is: " + uint.MaxValue);
            System.Console.WriteLine("The min value of an uint is: " + uint.MinValue); 
            
            //floating points
            double variable5 = 12343.52;
            variable5 = 0.3 - 0.2;
            //decimal

            //booleans
            bool variable6 = true; //false
            variable1 = ((5 + 3) * 2) / 3 % 2;
            variable6 = variable1 > 2;
            variable6 = variable1 <= 2;
            variable6 = variable1 == 2;
            
            //boolan algebra
            //and
            //c1 AND c2 &&
            //false  false  false
            //false  true   false
            //true   false  false
            //true   true   true
            variable6 = variable1 > 3 && variable2 < 5;

            //c1 OR c2 ||
            //false  false  false
            //false  true   true
            //true   false  true
            //true   true   true
            variable6 = variable1 > 3 || variable2 < 5;

            //not !
            //c1
            //true  false
            //false  true
            variable6 = !(variable1 > 3); //variable1 <= 3;
            
            //strings
            string variable7 = "Hi! I'm Simona";
            System.Console.WriteLine(variable7.Length);
            string variable8 = variable7.ToUpper(); 

            string variable9 = System.Console.ReadLine();
             

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World!");
        }
    }
}

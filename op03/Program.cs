using System;

namespace op03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string userInput = Console.ReadLine();
            //System.Console.WriteLine(userInput >= 18);
            
            int age = int.Parse(userInput);
            System.Console.WriteLine(age >= 18);

            //conversion
            string x = age.ToString();

            //cast
            int i = 5; //32 bit
            long l = 10 ; //64 bit
            //l = i; //implicit cast
            i = (int)l; //explicit cast
            //true if the userage >= 18
        }
    }
}

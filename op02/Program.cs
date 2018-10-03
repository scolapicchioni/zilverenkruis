using System;

namespace op02
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask "what's your name?"
            System.Console.WriteLine("what's your name?");
            
            //wait for an answer
            string userName = Console.ReadLine();
            
            //write "Hello " + what the user just said
            System.Console.WriteLine("Hello " + userName);
            
            //write "true" if the user name 
            //is longer than 5 letters ("false" otherwise)
            bool longerThanFive = userName.Length > 5;
            System.Console.WriteLine("longer than 5 letters: " + longerThanFive);
            
            //write "true" if the user name 
            //begins with an "A" or an "a" ("false" otherwise)
            bool startsWithAnA =  userName.StartsWith("A") || userName.StartsWith("a");
            System.Console.WriteLine("begins with an A or an a: " + startsWithAnA);
            
        }
    }
}

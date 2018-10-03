using System;

namespace op04
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
            if(longerThanFive)
            {
                System.Console.WriteLine("Your name is longer than 5 letters");
            }
            
            //write "true" if the user name 
            //begins with an "A" or an "a" ("false" otherwise)
            // bool startsWithAnA =  userName.StartsWith("A") || userName.StartsWith("a");
            // if(startsWithAnA)
            if (userName.StartsWith("A") || userName.StartsWith("a"))
            {
                System.Console.WriteLine("Your name begins with an A or an a!");
            }
            else 
            {
                System.Console.WriteLine("Your name does not begin with an A or an a!");
            }
            
            //challenge
            //generate a Random number between 1 and 100
            //ask the user to guess
            //tell the user if he guessed "too high!" or "too low!" or "you guessed!"
        }
    }
}

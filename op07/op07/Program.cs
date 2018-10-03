using System;

namespace op07 {
    class Program {
        static void Main(string[] args) {
            //Step 1: Generate random number
            Random randomNumberGenerator = new Random();
            int computerNumber = randomNumberGenerator.Next(1, 101); //for ints

            bool guessed = false;
            int numberOfGuesses = 0;
            while (!guessed) {
                numberOfGuesses++;
                //Step2: Ask the user a number
                Console.Write("Please enter a number between 1 and 100: ");
                string userInput = Console.ReadLine();
                int userNumber = int.Parse(userInput);
                //Step 3: Test if the user guessed correctly
                if (computerNumber == userNumber) {
                    //If yes, say "you won!"
                    Console.WriteLine("YOU WOOOOOOOON!!!!");
                    guessed = true;
                } else if (userNumber > computerNumber) {
                    //If not
                    //Test if the user is too high

                    //If yes, say "Too high!"
                    Console.WriteLine("Too high!");
                } else {
                    //If not, say "Too low"
                    Console.WriteLine("Too Low!");
                }
                Console.WriteLine("The computer generated a " + computerNumber);
            }
            Console.WriteLine("It took you " + numberOfGuesses + " guesses!");
            Console.ReadLine();
        }
    }
}

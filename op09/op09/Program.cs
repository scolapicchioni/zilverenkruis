using System;

namespace op09 {
    class Program {
        static void Main(string[] args) {
            //Step 1: Generate random number
            int computerNumber = GenerateRandomNumber();

            bool guessed;
            int numberOfGuesses = 0;
            do {
                numberOfGuesses++;
                //Step2: Ask the user a number
                int userNumber = AskNumberToUser();
                //Step 3: Test if the user guessed correctly
                guessed = Compare(computerNumber, userNumber);
            } while (!guessed);
            Console.WriteLine("It took you " + numberOfGuesses + " guesses!");
            Console.ReadLine();
        }

        private static bool Compare(int computerNumber, int userNumber) {
            bool guessed = false;
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

            return guessed;
        }

        private static int AskNumberToUser() {
            Console.Write("Please enter a number between 1 and 100: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        private static int GenerateRandomNumber() {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101); //for ints
            return randomNumber;
        }
    }
}

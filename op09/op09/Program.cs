using System;
using System.Data.SqlClient;

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

        //signature
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
            while (true) {
                Console.Write("Please enter a number between 1 and 100: ");

                //return int.Parse(Console.ReadLine());

                string userInput = Console.ReadLine();
                try {
                    int userNumber = int.Parse(userInput);
                    if (userNumber < 1 || userNumber > 100) {
                        Console.WriteLine("Between 1 and 100, please!!");
                    } else {
                        return userNumber;
                    }
                } catch (SqlException ex) {
                    
                } catch (FormatException ex) {

                    Console.WriteLine("I SAID NUMBER!!! " + ex.Message);
                } catch (OverflowException ex) {
                    //Console.WriteLine(ex.StackTrace); 
                    Console.WriteLine("Between " + int.MinValue + " and " + int.MaxValue + ", please!!");
                } catch (Exception ex) {
                    Console.WriteLine(ex.GetType().Name);
                }
            }
            
            
        }

        private static int GenerateRandomNumber() {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101); //for ints
            return randomNumber;
        }
    }
}

using System;

namespace op21.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            

            //Console.BackgroundColor = ConsoleColor.Red;

            ConsoleColor myFavoriteColor = ConsoleColor.White;

            Stuff(myFavoriteColor);

            Stuff(ConsoleColor.Magenta);

            Settings settings = new Settings();
            settings.Color = ConsoleColor.Cyan;


            Console.WriteLine(myFavoriteColor);
            Console.WriteLine(ConsoleColor.Blue);

            Console.WriteLine(myFavoriteColor.GetHashCode());

            int number = 9;
            myFavoriteColor = (ConsoleColor)number;


            string[] listOfAllThePossibleColors = Enum.GetNames(typeof(ConsoleColor));

            Console.WriteLine("**************");
            for (int i = 0; i < listOfAllThePossibleColors.Length; i++) {
                Console.WriteLine(listOfAllThePossibleColors[i]);
            }

            ConsoleColor anotherVariable = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), "Cyan");

            PhoneticAlphabet letter = PhoneticAlphabet.Alfa;

            number = 2;

            letter = (PhoneticAlphabet)number;

            PhoneticAlphabet secondLetter = PhoneticAlphabet.Charlie;

            if (letter == PhoneticAlphabet.Alfa) {

            }

            Console.WriteLine(letter);
            Console.ReadLine();
        }

        static void Stuff(ConsoleColor color) {

        }
    }

    //enumeration
}

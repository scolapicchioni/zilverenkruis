using System;

namespace op08 {
    class Program 
    {
        static void Main(string[] args) {
            //functions
            Console.WriteLine("Hi from Main!");
            SayHiToAnon();
            Console.WriteLine("Back to Main!");
            Method02();

            SayHiToSomebody("Simona");

            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();

            SayHiToSomebody(userName);

            SayHiToSomebodyMultipleTimes(userName,3+5);

            string blah = Console.ReadLine();

            int theResult = GenerateRandomNumberBetweenOneAndOneHundred();
            //tuple
            (int theIntRes, string theString, bool theBool) = MethodWithMultipleReturnValues();
            Console.WriteLine(GenerateRandomNumberBetweenOneAndOneHundred());

            Increment();
            Increment();
            Increment();

            int argument = 5;
            Console.WriteLine("Argument == " + argument);
            Change(ref argument); //pass by reference
            Console.WriteLine("Argument == " + argument);


            Console.ReadLine();
        }

        static void Change(ref int parameter) {
            Console.WriteLine("parameter == " + parameter);
            parameter++;
            Console.WriteLine("parameter == " + parameter);
        }

        static int counter; // 0
        static bool flag; //false
        string x; //null
        Random r; //null

        static void Increment() 
        {
            if (counter < 10) {
                counter++;
            }
        }

        static void Decrement() 
        {
            if (counter>0) {
                counter--;
            }
        }

        static (int, string, bool) MethodWithMultipleReturnValues() {
            //Console.WriteLine(userName); //not in scope!
            return (5, "Blah", true);
        }

        static int GenerateRandomNumberBetweenOneAndOneHundred() {
            int returnValue = 0;
            if (true) {
                returnValue = 10;
            } else {
                returnValue = 50;
            }

            return returnValue;
            Console.WriteLine("Stuff");
        }

        static void SayHiToSomebodyMultipleTimes(string whom, int howManyTimes) {
            for (int i = 0; i < howManyTimes; i++) {
                Console.WriteLine("Hi " + whom);
            }
        }

        static void SayHiToSomebody(string whom) {
            Console.WriteLine("Hi " + whom);
        }

        static void SayHiToAnon() 
        {
            Console.WriteLine("Oh Hi User!");
            Console.WriteLine("This is the SayHiToTheUser Method!!");

            Method02();

            Console.WriteLine("Still in the SayHiToTheUser Method");
            Console.WriteLine("SayHiToTheUser Method is leaving... bye!!");
        }

        static void Method02() {
            Console.WriteLine("Method 02");
        }



    }

    //not here!!!
    //static void SayHiToTheUser() {

    //}
}

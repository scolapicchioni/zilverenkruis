using System;
using System.Collections.Generic;
using System.Text;

namespace op13 {
    public class UniqueRandomNumberGenerator {
        //constructor
        //I can use it like this:
        //UniqueNumberGenerator gen = new UniqueNumberGenerator(10);
        public UniqueRandomNumberGenerator(int max) {
            generator = new Random();
            alreadyExtractedNumbers = new bool[max];
            counter = 0;
        }

        Random generator;
        bool[] alreadyExtractedNumbers;
        int counter;

        //I can use it like this:
        //int n = generator.Next();
        public int Next() 
        {
            if (counter > alreadyExtractedNumbers.Length) {
                throw new InvalidOperationException("I'm out of numbers, sorry....");
            }

            //keep extracting if you already have it in the list
            int number;
            do {
                number = generator.Next(1, alreadyExtractedNumbers.Length + 1);
            } while (alreadyExtractedNumbers[number - 1]);
            //if I'm here, I have a new number 
            alreadyExtractedNumbers[number - 1] = true;
            counter++;
            return number;
        }
    }
}

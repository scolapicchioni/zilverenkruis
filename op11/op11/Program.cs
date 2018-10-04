using System;

namespace op11 {
    class Program {
        static void Main(string[] args) {
            //array

            //int[] listOfNumbers; // <-- the pointer (reference) to the object
            //listOfNumbers = new int[10];
            //                      ^
            //                      |
            //                      L________ the object with the numbers

            //pointer and object created and connected at the same time
            //int[] listOfNumbers = new int[10]; //

            //If I only know a couple of elements, I can initialize them
            //like this
            //int[] listOfNumbers = new int[10];
            //listOfNumbers[0] = 22;
            //listOfNumbers[1] = 22;

            //if I know all the elements, I can initialize them
            //like this (array initializer)
            int[] listOfNumbers = new int[] { 22, 33, 12, 65, 24, 57, 24, 85, 35, 0 }; //array initializer

            //Arrays have properties, such as length
            Console.WriteLine("The length of the list is " + listOfNumbers.Length);

            //we usually use loops to scroll through the list,
            //using an index as position
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("The item at position " + i + " is " + listOfNumbers[i]);
            }

            //we can overwrite the items at any time
            //if we provide the index
            listOfNumbers[5] = 5;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("The item at position " + i + " is " + listOfNumbers[i]);
            }

            //the length is 10, but we can access 0 to 9
            //listOfNumbers[10] = 44; NOPE!!

            //an array can have multiple dimensions
            int[,] matrixOfNumbers = new int[5, 3]
            {
                { 1,    2,  3  },
                { 4,    5,  6  },
                { 7,    8,  9  },
                { 10,   11, 12 },
                { 13,   14, 15 }
            };

            //but then we need multiple indexes (one for each dimension)
            matrixOfNumbers[1, 1] = 999999999;

            Console.WriteLine(matrixOfNumbers[1,1]);

            //we usually use multiple loops to scroll
            //through arrays with multiple dimensions
            for (int row = 0; row < 5; row++) {
                for (int column = 0; column < 3; column++) {
                    Console.WriteLine($"matrix[{row} , {column}] == {matrixOfNumbers[row, column]}");
                }
            }

            //matrixOfNumbers.Length

            Console.WriteLine("********************************");
            PrintList(listOfNumbers);
            Console.WriteLine("********************************");
            PrintMatrix(matrixOfNumbers);


            listOfNumbers[0] = 12345;
            Console.WriteLine(listOfNumbers[0]);
            ChangeList(listOfNumbers);
            Console.WriteLine(listOfNumbers[0]);


            int arg = 12345;
            Console.WriteLine(arg);
            ChangeNumber(arg);
            Console.WriteLine(arg);

            int[] mycopy = listOfNumbers;
            mycopy[1] = 54321;
            Console.WriteLine(listOfNumbers[1]);



            Console.ReadLine();
        }

        static void ChangeNumber(int parameter) {
            Console.WriteLine(parameter);
            parameter=999999;
            Console.WriteLine(parameter);
        }

        static void ChangeList(int[] parameter) {
            Console.WriteLine(parameter[0]);
            parameter[0] = 999999999;
            Console.WriteLine(parameter[0]);
        }


        static void PrintList(int[] parameter) {
            for (int i = 0; i < parameter.Length; i++) {
                Console.WriteLine("The item at position " + i + " is " + parameter[i]);
            }
        }

        static void PrintMatrix(int[,] parameter) {
            for (int row = 0; row < parameter.GetLength(0); row++) {
                for (int column = 0; column < parameter.GetLength(1); column++) {
                    Console.WriteLine($"matrix[{row} , {column}] == {parameter[row, column]}");
                }
            }
        }
    }
}

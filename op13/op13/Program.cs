using System;

namespace op13 {
    class Program {
        static void Main(string[] args) {
            /*
             * Write a program that fills an array 
             * with dimension 3 x 3 
             * with random numbers between 1 and 9. 
             * Each random number may only occur 
             * once in the array.
             * */

            //INGREDIENTS:
            int rows = 3;
            int cols = 3;
            int[,] matrix = new int[rows, cols];
            
            //FILL IT:
            fillMatrix(matrix);

            //PRINT IT:
            printMatrix(matrix);

            Console.ReadLine();
        }

        private static void printMatrix(int[,] matrix) {
            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    Console.Write($"{matrix[row, col]}\t");
                }
                Console.WriteLine();
            }
        }

        private static void fillMatrix(int[,] matrix) {
            //INGREDIENTS:
            int numbersInTotal = matrix.GetLength(0) * matrix.GetLength(1);

            UniqueRandomNumberGenerator generator = new UniqueRandomNumberGenerator(numbersInTotal);
            
            //FILL IT:
            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    matrix[row, col] = generator.Next();
                }
            }
        }

    }
}

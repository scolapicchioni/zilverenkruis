using System;

namespace op06 {
    class Program {
        static void Main(string[] args) {
            //while (true) //infinite loop!
            //{
            //    Console.WriteLine("HI");
            //}

            int counter = 0;
            while (counter < 10) { //ten times, from 0 to 9
                Console.WriteLine("HI");
                //counter = counter + 1;
                //counter += 1;
                counter++;
            }

            counter = 0;
            do {
                counter++;
            } while (counter < 10);


            //initialization
            //int counter = 0;
            //test
            while (counter < 10) 
            {
                //repeat whatever

                //increment, or change the value of your condition
            }

            for (counter = 0 ; counter < 10; counter++) 
            {
                //repeat whatever
                Console.WriteLine(counter);
            }
            


            Console.WriteLine("Bye!");


            //write on the screen 5 4 3 2 1 liftoff!

            int countdown = 5;
            while (countdown>0) {
                Console.Write(countdown + " ");
                //countdown = countdown - 1;
                //countdown -= 1;
                countdown--;
            }
            Console.WriteLine("LIFTOFF!!");





            /////////////
            int a = 5;
            int b = a;
            //b == 5; a == 5;

            b = a++;
            //which is to say:
            //b = a;
            //a = a + 1;
            //and that's why we get
            //b == 5; a == 6


            a = 5;
            b = 5;

            b = ++a;
            //which is to say:
            //a = a + 1;
            //b = a;
            //and that's why we get
            //b == 6; a == 6

            a = 5;
            Console.WriteLine(a++); //5
            //which is to say:
            //Console.WriteLine(a);
            //a = a + 1;
            Console.WriteLine(a); //6

            a = 5;
            Console.WriteLine(++a); //6
            //which is to say:
            //a = a + 1;
            //Console.WriteLine(a);
            Console.WriteLine(a); //6
            /////////////

            a++;
            ++a;

            Console.ReadLine();
        }
    }
}

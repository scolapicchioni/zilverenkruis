using System;

namespace op12 {
    class Program {
        static void Main(string[] args) {
            MyCollection c1 = new MyCollection();
            MyCollection c2 = new MyCollection();
            MyCollection c3 = new MyCollection();
            c1.Add(22);
            c2.Add(33);
            c3.Add(44);
            c1.Add(111);

            Console.WriteLine(c1.listOfTheCollection[0]); //22
            c1.Add(123);
            Console.WriteLine(c1.listOfTheCollection[2]); //123

            for (int i = 0; i < 100; i++) {
                c1.Add(i);
            } 

            int x = c1.Count();

            int theSecondItem = c1.GetItemAt(1);

            c1.Print();

            Console.ReadLine();
        }

        
    }
}

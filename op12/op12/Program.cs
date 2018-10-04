using System;

namespace op12 {
    class Program {
        static void Main(string[] args) {
            int[] list = new int[10];

            Add(22);
            Console.WriteLine(list[0]); //22
            Add(123);
            Console.WriteLine(list[1]); //123
        }

        //Add: Adds a number at the end of the list

        //Remove: removes a number from the end of the list

        //InsertAt: inserts a number at a specified position

        //RemoveAt: removes an item at a specified position

        //IndexOf: returns the position of a specified item (-1 if not present)

        //GetItemAt: returns the item at a specified position

        //Contains: returns true if a specified item is found

        //Count: returns how many items are in the list

        //Print: prints the content of the list to the Console
    }
}

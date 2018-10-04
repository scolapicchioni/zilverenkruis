using System;
using System.Collections.Generic;
using System.Text;

namespace op12 {
    public class MyCollection {
        public int counter = 0;
        public int[] listOfTheCollection = new int[10];

        //Add: Adds a number at the end of the list
        //bonus points: if the list is full, double the size
        public  void Add(int item) {
            if (counter >= listOfTheCollection.Length) {
                int[] list2 = new int[2 * listOfTheCollection.Length];
                for (int i = 0; i < listOfTheCollection.Length; i++) {
                    list2[i] = listOfTheCollection[i];
                }
                listOfTheCollection = list2;
            }
            listOfTheCollection[counter++] = item;
        }

        //Count: returns how many items are in the list
        public int Count() {
            return counter;
        }

        //GetItemAt: returns the item at a specified position
        public int GetItemAt(int position) {
            int toReturn = listOfTheCollection[position];
            return toReturn;
        }

        //Print: prints the content of the list to the Console
        public void Print() {
            for (int i = 0; i < counter; i++) {
                Console.WriteLine(listOfTheCollection[i]);
            }
        }


        //////////////////////////////////////////////////////////

        //Remove: removes a number from the end of the list

        //InsertAt: inserts a number at a specified position

        //RemoveAt: removes an item at a specified position

        //IndexOf: returns the position of a specified item (-1 if not present)

        //Contains: returns true if a specified item is found
    }
}

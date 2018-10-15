using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic.Utilities {
    public class List<TheTypeOfTheItemToStore> { //generic
        public List() {
            recipes = new TheTypeOfTheItemToStore[200];
        }
        private TheTypeOfTheItemToStore[] recipes;

        private int count;
        public int Count => count;

        public void Add(TheTypeOfTheItemToStore recipe) {
            recipes[count++] = recipe;
        }

        public TheTypeOfTheItemToStore this[int index] => recipes[index];
    }
}

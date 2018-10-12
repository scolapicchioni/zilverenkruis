using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class ListOfRecipes {
        private Recipe[] recipes = new Recipe[20];
        public int Count { get; private set; }
        public void Add(Recipe toAdd) {
            recipes[Count++] = toAdd;
        }
        public Recipe Get(int index) { return recipes[index]; }
    }
}

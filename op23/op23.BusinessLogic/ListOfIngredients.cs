using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class ListOfIngredients {
        private Ingredient[] ingredients = new Ingredient[20];
        public int Count { get; private set; }
        public void Add(Ingredient toAdd) {
            ingredients[Count++] = toAdd;
        }
        public Ingredient Get(int index) { return ingredients[index]; }
    }
}

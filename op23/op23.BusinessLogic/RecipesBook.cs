using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class RecipesBook {
        public string Author { get; set; }
        public string Title { get; set; }
        public ListOfRecipes Recipes { get; private set; }
        public RecipesBook() {
            Recipes = new ListOfRecipes();
        }
    }
}

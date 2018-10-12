using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class Recipe: BookItem {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Difficulty Difficulty { get; set; }
        public ListOfIngredients Ingredients { get; private set; }
        public Recipe() {
            Ingredients = new ListOfIngredients();
        }
    }

    public enum Difficulty {
        Easy, Medium, Expert
    }
}

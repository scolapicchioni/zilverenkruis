using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class Recipe {
        public string Title { get; set; }
        public int Duration { get; set; }
        //carbonara.Description
        public string Description { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<Ingredient> Ingredients { get; private set; }
        public Recipe() {
            Ingredients = new List<Ingredient>();
        }
        
    }

    public enum Difficulty {
        Easy, Medium, Advanced
    }
}

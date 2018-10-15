using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class Recipes : List<Recipe>{
        public Recipes Filter(RecipeChecker check) {
            Recipes recipes = new Recipes();
            foreach (Recipe item in this) {
                if (check(item))
                    recipes.Add(item);
            }
            return recipes;
        }
    }

    public delegate bool RecipeChecker(Recipe recipe);
}

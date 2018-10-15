using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class Ingredients : List<Ingredient>{
        public Ingredients Filter(IngredientChecker check) {
            Ingredients recipes = new Ingredients();
            foreach (Ingredient item in this) {
                if (check(item))
                    recipes.Add(item);
            }
            return recipes;
        }
    }

    public delegate bool IngredientChecker(Ingredient recipe);
}

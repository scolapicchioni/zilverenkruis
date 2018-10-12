using op23.BusinessLogic;
using System;

namespace op23.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            RecipesBook book = new RecipesBook();
            Console.WriteLine(book.Recipes.Count);

            Recipe r = new Recipe();
            r.Ingredients.Add(new Ingredient() { Name = "", Quantity = "" });

            book.Recipes.Add(r);

            Console.WriteLine(book.Recipes.Get(0).Title);

            //r.Ingredients.Add(new Recipe());

            ListOfBookItem l = new ListOfBookItem();
            l.Add(new Recipe());
            l.Add(new Ingredient());


            Console.ReadLine();
        }
    }
}

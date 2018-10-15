
using op23.BusinessLogic;
using System;

namespace op23.ConsoleApplication {
    class Program {
        static void Main(string[] args) {

            Ingredient pasta = new Ingredient() { Name = "fusilli", Quantity = "250 gr" };
            Ingredient eggs = new Ingredient() { Name = "eggs", Quantity = "3" };
            Ingredient parmesan = new Ingredient() { Name = "parmesan", Quantity = "50 gr" };

            Recipe carbonara = new Recipe() {
                Title = "Pasta alla carbonara",
                Description = "fghjdskhgdjkgf",
                Difficulty = Difficulty.Easy,
                Duration = 10
            };

            carbonara.Ingredients.Add(pasta);
            carbonara.Ingredients.Add(eggs);
            carbonara.Ingredients.Add(parmesan);

            for (int i = 0; i < carbonara.Ingredients.Count; i++) {
                Console.WriteLine($"{carbonara.Ingredients[i].Name} {carbonara.Ingredients[i].Quantity}");
            }
            
            CookBook book = new CookBook() { Title = "Simona's cooking for Dutch people", Author = "Simona" };

            book.Recipes.Add(carbonara);

            Console.WriteLine("************************");
            for (int i = 0; i < book.Recipes.Count; i++) {
                Console.WriteLine($"{book.Recipes[i].Title}");
            }
            
            Console.ReadLine();
        }
    }
}

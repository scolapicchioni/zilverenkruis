
using op23.BusinessLogic;
using System;

namespace op23.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            CookBook book = new CookBook() { Title = "Simona's CookBook", Author = "Simona" };

            fillBook(book);

            PrintRecipes(book.Recipes);

            //print all the easy recipes
            PrintRecipes(book.Recipes.Filter(r => r.Difficulty == Difficulty.Easy));

            //print all the pasta recipes
            Recipes pastarecipes = book.Recipes.Filter(r => r.Ingredients.Filter(i => i.Name.ToLower().Contains("pasta")).Count > 0);

            PrintRecipes(pastarecipes);

            Console.ReadLine();
        }

        static void fillBook(CookBook book) {
            Ingredient fusilli = new Ingredient() { Name = "pasta fusilli", Quantity = "250 gr" };
            Ingredient tagliatelle = new Ingredient() { Name = "pasta tagliatelle", Quantity = "250 gr" };
            Ingredient eggs = new Ingredient() { Name = "eggs", Quantity = "3" };
            Ingredient parmesan = new Ingredient() { Name = "parmesan", Quantity = "50 gr" };
            Ingredient speck = new Ingredient() { Name = "speck", Quantity = "100 gr" };
            Ingredient mushrooms = new Ingredient() { Name = "mushrooms", Quantity = "250 gr" };
            Ingredient pumpkin = new Ingredient() { Name = "pumpkin", Quantity = "250 gr" };
            Ingredient chicken = new Ingredient() { Name = "chicken", Quantity = "200 gr" };
            Ingredient tomatoes = new Ingredient() { Name = "tomatoes", Quantity = "250 gr" };

            Recipe carbonara = new Recipe() {
                Title = "Pasta Carbonara",
                Description = "Easypeasy",
                Difficulty = Difficulty.Easy,
                Duration = 10
            };

            carbonara.Ingredients.Add(fusilli);
            carbonara.Ingredients.Add(eggs);
            carbonara.Ingredients.Add(parmesan);
            carbonara.Ingredients.Add(speck);

            Recipe pollofunghi = new Recipe() {
                Title = "Chicken with Mushrooms",
                Duration = 50,
                Difficulty = Difficulty.Advanced
            };

            pollofunghi.Ingredients.Add(chicken);
            pollofunghi.Ingredients.Add(mushrooms);

            Recipe pastazuccafunghi = new Recipe() {
                Title = "Pasta with pumpkin and mushrooms",
                Duration = 30,
                Difficulty = Difficulty.Medium
            };
            pastazuccafunghi.Ingredients.Add(tagliatelle);
            pastazuccafunghi.Ingredients.Add(pumpkin);
            pastazuccafunghi.Ingredients.Add(mushrooms);
            pastazuccafunghi.Ingredients.Add(parmesan);

            Recipe amatriciana = new Recipe() {
                Title = "Pasta Amatriciana",
                Description = "Easypeasy",
                Difficulty = Difficulty.Easy,
                Duration = 10
            };

            amatriciana.Ingredients.Add(fusilli);
            amatriciana.Ingredients.Add(tomatoes);
            amatriciana.Ingredients.Add(speck);


            book.Recipes.Add(carbonara);
            book.Recipes.Add(pollofunghi);
            book.Recipes.Add(pastazuccafunghi);
            book.Recipes.Add(amatriciana);
        }

        static void PrintRecipes(Recipes recipes) {
            Console.WriteLine("************************");
            for (int i = 0; i < recipes.Count; i++) {
                Console.WriteLine($"{recipes[i].Title}");
                foreach (Ingredient ingredient in recipes[i].Ingredients) {
                    Console.WriteLine($"\t{ingredient.Name}");
                }
            }
        }
    }
}

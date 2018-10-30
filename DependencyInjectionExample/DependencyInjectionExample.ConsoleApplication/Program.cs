using System;

namespace DependencyInjectionExample.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            Dice dice = new Dice();
            Player p1 = new Player(dice);
            Player p2 = new Player(dice);

            Game game = new Game();

            game.Player1 = p1;
            game.Player2 = p2;

            Player winner = game.Start();

            if (winner == p1) {
                Console.WriteLine("p1 won");
            } else if (winner == p2) {
                Console.WriteLine("p2 won");
            } else {
                Console.WriteLine("tie");
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace op20.ConsoleApp {
    class Program {
        static void Main(string[] args) {
            IPlayer player1 = makePlayer();
            IPlayer player2 = makePlayer();

            Game game = new Game(player1, player2);

            game.Start();

            Console.ReadLine();
        }
        static IPlayer makePlayer() {
            Console.Write("1 For Human, 2 for Computer");
            int choice = int.Parse(Console.ReadLine());
            IPlayer player;
            if (choice == 1)
                player = new Human();
            else {
                player = new Computer();
            }
            Console.WriteLine($"Please enter the name (Enter to accept {player.Name}): ");

            string name = Console.ReadLine();
            if (name != "") {
                player.Name = name;
            }
            return player;
        }
    }
}

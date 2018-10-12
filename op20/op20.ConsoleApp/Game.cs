using System;
using System.Collections.Generic;
using System.Text;

namespace op20.ConsoleApp {
    public class Game {
        public IPlayer Player1 { get; }
        public IPlayer Player2 { get; }
        public Game(IPlayer player1, IPlayer player2) {
            Player1 = player1;
            Player2 = player2;
        }

        public int NumberOfTurns { get; private set; }
        public void Start() {
            Console.WriteLine("Game starting");
            bool playAgain;
            do {
                Console.Clear();
                Round newRound = new Round(Player1, Player2);
                NumberOfTurns++;
                newRound.Play();
                System.Console.WriteLine($"{Player1.Name} chose {Player1.LastChoice}");
                System.Console.WriteLine($"{Player2.Name} chose {Player2.LastChoice}");
                if (newRound.Winner == null) {
                    Console.WriteLine("TIE");
                } else {
                    Console.WriteLine(newRound.Winner.Name + " won!");
                }
                writeStats();
                Console.WriteLine("Continue (y/n)?");
                playAgain = Console.ReadLine().ToLower() != "n";
            }while(playAgain);

            Console.WriteLine("Bye");
        }

        private void writeStats() {
            Console.WriteLine($"Stats:");
            Console.WriteLine($"\tTurns:{NumberOfTurns}");
            Console.WriteLine($"\t{Player1.Name}: {Player1.Score}");
            Console.WriteLine($"\t{Player2.Name}: {Player2.Score}");
        }
    }
}

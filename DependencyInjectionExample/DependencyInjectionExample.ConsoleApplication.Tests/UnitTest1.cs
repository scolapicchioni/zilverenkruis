using System;
using Xunit;

namespace DependencyInjectionExample.ConsoleApplication.Tests {
    public class GameTests {
        [Fact]
        public void WhenPlayer1ScoresMoreThanPlayer2_ThenPlayer1ShouldWin() {
            WinningDice winningDice = new WinningDice();
            LoserDice loser = new LoserDice();
            Player p1 = new Player(winningDice);
            Player p2 = new Player(loser);

            Game game = new Game();

            game.Player1 = p1;
            game.Player2 = p2;

            Player winner = game.Start();

            Assert.Equal(p1, winner);
        }

        [Fact]
        public void WhenPlayer1ScoresAsPlayer2_ThenPlayer1ShouldWin() {
            WinningDice winningDice = new WinningDice();
            Player p1 = new Player(winningDice);
            Player p2 = new Player(winningDice);

            Game game = new Game();

            game.Player1 = p1;
            game.Player2 = p2;

            Player winner = game.Start();

            Assert.Null(winner);
        }
    }
}

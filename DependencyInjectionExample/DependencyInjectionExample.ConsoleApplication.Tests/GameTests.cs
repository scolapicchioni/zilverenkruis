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
        public void WhenPlayer1ScoresMoreThanPlayer2_ThenPlayer1ShouldWin_WithMoq() {
            Moq.Mock<IDice> winnerMock = new Moq.Mock<IDice>();
            winnerMock.Setup(d => d.Roll()).Returns(() => 6);

            Moq.Mock<IDice> loserMock = new Moq.Mock<IDice>();
            loserMock.Setup(d => d.Roll()).Returns(() => 1);

            Player p1 = new Player(winnerMock.Object);
            Player p2 = new Player(loserMock.Object);

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

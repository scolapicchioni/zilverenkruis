namespace op20.ConsoleApp {
    internal class Round {
        IPlayer player1;
        IPlayer player2;
        public IPlayer Winner { get; private set; }

        internal Round(IPlayer p1, IPlayer p2) {
            player1 = p1;
            player2 = p2;
        }

        internal void Play() {
            player1.Play();
            player2.Play();
            
            Winner = whoWon();
            if(Winner !=null)
                Winner.Score++;
        }

        private IPlayer whoWon() {
            int[,] combinations = new int[3, 3] {
                { 0, 1, 2 },
                { 2, 0, 1 },
                { 1, 2, 0 }
            };
            IPlayer winner = null;
            int p1Choice = (int)player1.LastChoice - 1;
            int p2Choice = (int)player2.LastChoice - 1;
            if (combinations[p2Choice, p1Choice] == 0) {
                winner = null;
            } else if (combinations[p2Choice, p1Choice] == 1) {
                winner = player1;
            } else {
                winner = player2;
            }
            return winner;
        }
    }
}
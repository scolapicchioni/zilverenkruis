namespace op20.ConsoleApp {
    internal class Turn {
        IPlayer player1;
        IPlayer player2;
        public IPlayer Winner { get; private set; }

        internal Turn(IPlayer p1, IPlayer p2) {
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
            if (combinations[(int)player2.LastChoice, (int)player1.LastChoice] == 0) {
                winner = null;
            } else if (combinations[(int)player2.LastChoice, (int)player1.LastChoice] == 1) {
                winner = player1;
            } else {
                winner = player2;
            }
            return winner;
        }
    }
}
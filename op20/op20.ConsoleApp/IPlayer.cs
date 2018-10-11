using System;
using System.Collections.Generic;
using System.Text;

namespace op20.ConsoleApp {
    public interface IPlayer {
        string Name { get; set; }
        int Score { get; set; }
        Choice LastChoice { get; set; }
        void Play();
    }

    public enum Choice {
        Rock,Paper,Scissors
    }
}

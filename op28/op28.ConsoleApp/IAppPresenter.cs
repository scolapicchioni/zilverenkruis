using System;
using System.Collections.Generic;
using System.Text;

namespace op28.ConsoleApp {
    public interface IAppPresenter {
        void Start();
        string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public abstract class App : IApp {
        public App(string name) {
            Name = name;
        }
        private string name;
        public string Name {
            get { return name; }
            set {
                if (value.Length > 50)
                    value = value.Substring(0, 50);
                name = value;
            }
        }

        public abstract void Install();

        public abstract void Start();
    }
}

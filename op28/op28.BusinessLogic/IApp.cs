using System;
using System.Collections.Generic;
using System.Text;

namespace op28.BusinessLogic {
    public interface IApp {
        void Start();
        void Install();
        string Name { get; set; }
    }
}

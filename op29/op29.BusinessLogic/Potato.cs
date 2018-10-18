using System;
using System.Collections.Generic;
using System.Text;

namespace op29.BusinessLogic {
    [Serializable]
    public class Potato : IComparable {
        public string Color { get; set; }
        public string Shape { get; set; }
        public int Size { get; set; }
        public bool SnelKokend { get; set; }

        public int CompareTo(object obj) {
            //+1 I'm bigger than obj
            //-1 I'm smaller than obj
            //0 I'm equal to object
            return Size - ((Potato)obj).Size;
        }

        public override string ToString() {
            return $"{Color} {Shape} {Size} {SnelKokend}";
        }

    }
}

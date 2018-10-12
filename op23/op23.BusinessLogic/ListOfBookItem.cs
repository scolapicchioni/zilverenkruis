using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class ListOfBookItem {
        private BookItem[] recipes = new BookItem[20];
        public int Count { get; private set; }
        public void Add(BookItem toAdd) {
            recipes[Count++] = toAdd;
        }
        public BookItem Get(int index) { return recipes[index]; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace op23.BusinessLogic {
    public class CookBook {
        public string Title { get; set; }
        public string Author { get; set; }

        public Recipes Recipes { get; private set; }
        public CookBook() {
            Recipes = new Recipes();
        }
        
    }
}

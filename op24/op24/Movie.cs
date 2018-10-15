using System;
using System.Collections.Generic;
using System.Text;

namespace op24 {
    public class Movie {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public override string ToString() {
            return $"{Title} - ({Year}) - {Genre} - {Rating}%";
        }
    }
}

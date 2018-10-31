using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa02.Models {
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public List<Comment> Comments { get; set; } 
    }
}

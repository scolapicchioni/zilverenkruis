using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa02.Models {
    public class Comment {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Body { get; set; }
        public int MovieId { get; set; }
    }
}

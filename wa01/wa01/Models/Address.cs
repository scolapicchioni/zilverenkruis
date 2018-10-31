using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wa01.Models {
    public class Address {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public int PersonId { get; set; } //foreign key

    }
}

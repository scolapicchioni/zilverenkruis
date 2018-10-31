using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wa01.Models {
    public class Person {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public int Age { get; set; }

        public List<Address> Addresses { get; set; }
    }
}

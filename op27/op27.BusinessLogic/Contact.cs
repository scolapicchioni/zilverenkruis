using System;

namespace op27.BusinessLogic {
    public class Contact {
        private string surname;

        public string Surname {
            get { return surname; }
            set { if (value.Length > 50)
                    value = value.Substring(0, 50);
                surname = value;
            }
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
        public string PhoneNumber { get; set; }
    }
}

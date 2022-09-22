using System;

namespace PhoneBook
{
    class Contact
    {
        public string Name { get; set; }
        private string Number { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", phone: " + Number;
        }
    }
}
using System;

namespace PhoneBook
{
    class PhoneBook
    {
        private List<Contact> ContactList { get; set; }

        public PhoneBook()
        {
            ContactList = new List<Contact>();
        }

        public void AddContact(Contact contact) => ContactList.Add(contact);

        public Contact FindContactByName(string name) => ContactList.FirstOrDefault(c => c.Name == name);

        public void UpdateContact(string name)
        {

        }

        public void DeleteContactByName(String name)
        {
            Contact contact = FindContactByName(name);

            if (contact != null)
            {
                ContactList.Remove(FindContactByName(name));
            }
            else
            {
                Console.WriteLine("No contact with that name");
            }
        }

        public void DisplayAllContacts()
        {
            if(this.ContactList.Count > 0)
            {
                foreach (Contact contact in this.ContactList)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
            else
            {
                Console.WriteLine("No contacts on contact list");
            }
            
        }

        public void DisplayContact(string name)
        {
            Contact contact = this.FindContactByName(name);

            if (contact != null)
            {
                Console.WriteLine(contact.ToString());
            }
            else
            {
                Console.WriteLine("No contact with that name");
            }

        }
    }
}
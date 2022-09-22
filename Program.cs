using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneBook();

            while (true)
            {
                Console.WriteLine("Hello. What would you like to do?");

                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display all contacts");
                Console.WriteLine("3. Display contact");
                Console.WriteLine("4. Update contact");
                Console.WriteLine("5. Delete contact");
                Console.WriteLine("0. Close the app");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        phoneBook.AddContact(CreateContact());
                        break;
                    case "2":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "3":
                        phoneBook.DisplayContact(GetName());
                        break;
                    case "4":
                        phoneBook.UpdateContact(GetName());
                        break;
                    case "5":
                        phoneBook.DeleteContactByName(GetName());
                        break;
                    case "0":
                        Console.WriteLine("Shut down the app..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
            }
        }

        private static string GetName()
        {
            Console.WriteLine("Podaj nazwe kontaktu");
            String inputName = Console.ReadLine();
            return inputName;
        }

        private static Contact CreateContact()
        {
            Console.WriteLine("Podaj nazwe kontaktu");
            String inputName = Console.ReadLine();
            Console.WriteLine("Podaj numer kontaktu");
            String inputPhone = Console.ReadLine();
            return new Contact(inputName, inputPhone);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        Dictionary<string, AddressBook> addressbooks  = new Dictionary<string, AddressBook>();
        static Program()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }
        public void AddAddressBook()
        {
            Console.WriteLine("Enter address book name");
            AddressBook user = new AddressBook();
            user.AddressBookName = Console.ReadLine();
            addressbooks.Add(user.AddressBookName, user);
            Console.WriteLine($"Welcome to {user.AddressBookName}");
            user.ChooseOption();

        }

        public void AddNewAddressBook()
        {
            AddAddressBook();
        }
        
        public void DisplayAddressBook()
        {
            foreach (KeyValuePair<string, AddressBook> books in addressbooks)
            {
                Console.WriteLine("This are following AddressBooks of {0} ", books.Key);

            }
        }
    static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                Console.WriteLine("Choose the option ");
                Console.WriteLine("Type 1 to Add Address Book ");
                Console.WriteLine("Type 2 to Add New Address Book ");
                Console.WriteLine("Type 3 to Display Address Book ");
                Console.WriteLine("Type 0 to Exit ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    program.AddAddressBook();
                }
                else if(option == "2")
                {
                    program.AddNewAddressBook();
                }
                else if (option == "3")
                {
                    program.DisplayAddressBook();
                }
                else
                    break;
                }
            
            

        }
    }
}

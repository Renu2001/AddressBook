using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        Dictionary<string, AddressBook> addressbookslist  = new Dictionary<string, AddressBook>();
        static Program()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }
        public void AddAddressBook()
        {
            Console.WriteLine("Enter address book name : ");
            AddressBook user = new AddressBook();
            user.AddressBookName = Console.ReadLine();
            if (!addressbookslist.ContainsKey(user.AddressBookName))
            {
                addressbookslist.Add(user.AddressBookName, user);
                Console.WriteLine($"Welcome to {user.AddressBookName}");
                Console.WriteLine("If you want to add contacts type 1");
                Console.WriteLine("If you want to add new book type 2");
                Console.WriteLine("If you want to exit type 0");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    user.ChooseOption();
                }
                else if (input == "2")
                {
                    AddAddressBook();
                }
               
            }
            else
                Console.WriteLine("AddressBook Already Exists !!");
            
        }
        public void DisplayAddressBook()
        {
            foreach (var books in addressbookslist.Values)
            {
                Console.WriteLine("This are contacts of {0} ", books.AddressBookName);
                foreach (var contact in books.contactlist.Values) 
                {
                    if (contact != null)
                        Console.WriteLine(contact.DisplayRecord());
                    else
                        Console.WriteLine("There are no contacts here");
                }
                
            }
        }

        public void SearchByCity()
        {
            bool flag = false;
            Console.WriteLine("Enter name of city");
            string cityname = Console.ReadLine();
            foreach (var books in addressbookslist.Values)
            {
                    foreach (var contact in books.contactlist.Values)
                    {
                        if (contact.City.Equals(cityname))
                        {
                            flag = true;
                            Console.WriteLine("=========================================");
                            Console.WriteLine(contact.DisplayRecord());
                            Console.WriteLine("=========================================");
                        }
                    }
            }
            if (flag == true)
                Console.WriteLine("Record Not Found");
        
            
        }
    static void Main(string[] args)
        {
            Program program = new Program();
            while (true)
            {
                Console.WriteLine("\nChoose the option ");
                Console.WriteLine("Type 1 to Add Address Book ");
                Console.WriteLine("Type 2 to Add New Address Book ");
                Console.WriteLine("Type 3 to Display Address Book ");
                Console.WriteLine("Type 3 to Search contact by city name ");
                Console.WriteLine("Type 0 to Exit ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        program.AddAddressBook();
                        break;
                    case 2:
                        program.AddAddressBook();
                        break;
                    case 3:
                        program.DisplayAddressBook();
                        break;
                    case 4:
                        program.SearchByCity();
                        break;
                    default:
                        break;
                }
                if (option == 0)
                    break;

            }   
            
        }
    }
}

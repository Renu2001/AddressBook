using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        public Dictionary<string, AddressBook> addressbookslist = new Dictionary<string, AddressBook>();

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
                Console.WriteLine("\nThis are contacts of {0} ", books.AddressBookName);
                foreach (var contact in books.contactlist.Values)
                {
                    if (contact != null)
                        Console.WriteLine(contact.DisplayRecord());
                    else
                        Console.WriteLine("There are no contacts here");
                }

            }
        }
        public void DisplayAddressBookByName()
        {
            foreach (var books in addressbookslist.Values)
            {
                Console.WriteLine("\nThis are contacts of {0} ", books.AddressBookName);
                foreach (var contact in books.contactlist.Values.OrderBy(key => key.FirstName))
                {
                    if (contact != null)
                        Console.WriteLine(contact.DisplayRecord());
                    else
                        Console.WriteLine("There are no contacts here");
                }

            }
        }
        public void SortByCity_State_Zip(string option)
        {
            foreach (var books in addressbookslist.Values)
            {
                Console.WriteLine($"\nThese are contacts of {books.AddressBookName}");

                List<Contacts> sortedContacts = new List<Contacts>(books.contactlist.Values);

                if (option == "city")
                {
                    sortedContacts.Sort((c1, c2) => c1.City.CompareTo(c2.City));
                }
                else if (option == "state")
                {
                    sortedContacts.Sort((c1, c2) => c1.State.CompareTo(c2.State));
                }
                else if (option == "zip")
                {
                    sortedContacts.Sort((c1, c2) => c1.ZipCode.CompareTo(c2.ZipCode));
                }

                if (sortedContacts.Count > 0)
                {
                    foreach (var contact in sortedContacts)
                    {
                        Console.WriteLine(contact.DisplayRecord());
                    }
                }
                else
                {
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
            if (flag == false)
                Console.WriteLine("Record Not Found");


        }
        public void CountPersonByCity()
        {
            int count = 0;
            Console.WriteLine("Enter name of city");
            string cityname = Console.ReadLine();
            foreach (var books in addressbookslist.Values)
            {
                List<Contacts> citynames = new List<Contacts>(books.contactlist.Values);
                count = citynames.Count;
            
            }
            Console.WriteLine("Total no of person" + count);
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
                    Console.WriteLine("Type 4 to Search contact by city name ");
                    Console.WriteLine("Type 5 to count by city ");
                    Console.WriteLine("Type 6 to Sort by Name ");
                    Console.WriteLine("Type 7 to Sort by city/Zip/State ");
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
                        case 5:
                            program.CountPersonByCity();
                            break;
                        case 6:
                            program.DisplayAddressBookByName();
                            Console.WriteLine("Sorted By Name");

                        break;
                        case 7:
                            Console.WriteLine("How you want to sort by zip/state/city");
                            string a = Console.ReadLine();
                            program.SortByCity_State_Zip(a);
                            Console.WriteLine("Sorted");
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

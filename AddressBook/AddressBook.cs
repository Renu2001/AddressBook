using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    internal class AddressBook
    {
        public string AddressBookName { get; set; }

        Dictionary<string, Contacts> contactlist = new Dictionary<string, Contacts>();

        public void UpdateContact(string name)
        {
            if (contactlist.ContainsKey(name))
            {
                Contacts contactToUpdate = contactlist[name];
                contactToUpdate.GetUserInfo();
                Console.WriteLine("Updated the record.");
            }
            else
            {
                Console.WriteLine($" Record not found.");
            }
        }

        public void DeleteContact(string name)
        {
            if (contactlist.ContainsKey(name))
            {
                contactlist.Remove(name);
                Console.WriteLine("Deleted the record.");
            }
            else
            {
                Console.WriteLine($" Record not found.");
            }
        }

        public void SearchByCity(string city)
        {
            if (contactlist.Count > 0)
            {

                foreach (Contacts contact in contactlist.Values)
                {
                    if (contact.City.Equals(city))
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine(contact.DisplayRecord());
                        Console.WriteLine("=========================================");
                    }
                }


            }
            else
                Console.WriteLine("No Records Found !!");
        }


        public void ChooseOption()
        {
            while (true)
            {

                Console.WriteLine("\nIf you want to Add contact type 1");
                Console.WriteLine("If you want to Display contact type 2");
                Console.WriteLine("If you want to Update contact type 3");
                Console.WriteLine("If you want to Delete contact type 4");
                Console.WriteLine("If you want to Search contact by City type 5");
                Console.WriteLine("If you want to close type 0");
                Console.Write("\nEnter Your Choice : ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Contacts c = new Contacts();
                    c.GetUserInfo();
                    if (!contactlist.ContainsKey(c.FirstName))
                        contactlist.Add(c.FirstName, c);
                    else
                        Console.WriteLine("Contact Already Exists....");
                }
                else if (input == "2")
                {
                    if (contactlist.Count > 0)
                    {
                        foreach (Contacts contact in contactlist.Values)
                        {
                            Console.WriteLine("=========================================");
                            Console.WriteLine(contact.DisplayRecord());
                            Console.WriteLine("=========================================");
                        }
                    }
                    else
                        Console.WriteLine("No Records Found !!");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter name to update");
                    string name = Console.ReadLine();
                    UpdateContact(name);

                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter name to delete");
                    string name = Console.ReadLine();
                    DeleteContact(name);

                }
                else if (input == "5")
                {
                    Console.WriteLine("Enter city to search");
                    string name = Console.ReadLine();
                    SearchByCity(name);

                }
                else if (input == "0")
                    break;

            }

        }

    }
}

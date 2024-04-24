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

        List<Contacts> contactlist = new List<Contacts>();
        public void UpdateContact(string name)
        {
            Contacts contactToUpdate = contactlist.Find(c => c.FirstName.Equals(name));
            if (contactToUpdate != null)
            {
                contactToUpdate.GetUserInfo();
                Console.WriteLine($" Updated the record ");
            }
            else
            {
                Console.WriteLine($" Record not found.");
            }
        }

        public void DeleteContact(string name)
        {
            Contacts contactToDelete = contactlist.Find(c => c.FirstName.Equals(name));
            if (contactToDelete != null)
            {
                contactlist.Remove(contactToDelete);
                Console.WriteLine($" Deleted the record ");
            }
            else
            {
                Console.WriteLine($" Record not found.");
            }
        }

        

        public void ChooseOption()
        {
            while (true)
            {

                Console.WriteLine("\nIf you want to Add contact type 1");
                Console.WriteLine("If you want to Display contact type 2");
                Console.WriteLine("If you want to Update contact type 3");
                Console.WriteLine("If you want to Delete contact type 4");
                Console.WriteLine("If you want to close type 0");
                Console.Write("\nEnter Your Choice : ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Contacts c = new Contacts();
                    c.GetUserInfo();
                    contactlist.Add(c);
                }
                else if (input == "2")
                {
                    if (contactlist.Count > 0)
                    { 
                        foreach (Contacts contact in contactlist)
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
                else if (input == "0")
                    break;

            }

        }
        
    }
}

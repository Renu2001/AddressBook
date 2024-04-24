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
        List<Contacts> contactlist = new List<Contacts>();
        static AddressBook()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }

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
        static void Main(string[] args)
        {

            AddressBook a = new AddressBook();

            while (true)
            {
                
                Console.WriteLine("\nIf you want to add contact type 1");
                Console.WriteLine("If you want to display contact type 2");
                Console.WriteLine("If you want to update contact type 3");
                Console.WriteLine("If you want to close type 0");
                Console.Write("\nEnter Your Choice : ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    
                    Contacts c = new Contacts();
                    c.GetUserInfo();
                    a.contactlist.Add(c);
                }
                else if (input == "2")
                {
                    foreach (Contacts contact in a.contactlist)
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine(contact.DisplayRecord());
                        Console.WriteLine("=========================================");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter name to update");
                    string name = Console.ReadLine();
                    a.UpdateContact(name);

                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter name to delete");
                    string name = Console.ReadLine();
                    a.DeleteContact(name);

                }
                else if(input == "0") 
                    break;

            }
            
            

            
        }
    }
}

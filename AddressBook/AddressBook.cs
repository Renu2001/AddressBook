using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook 
{
    internal class AddressBook
    {
        List<Contacts> contactlist = new List<Contacts>();
        static AddressBook()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }

        public void UpdateContactName(string currentName, string newName)
        {
            Contacts contactToUpdate = contactlist.Find(c => c.FirstName.Equals(currentName));
            if (contactToUpdate != null)
            {
                contactToUpdate.FirstName = newName;
                Console.WriteLine($" Updated the name : {currentName} ");
            }
            else
            {
                Console.WriteLine($" Record {currentName} not found.");
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
                    string currentname = Console.ReadLine();
                    Console.WriteLine("Enter name to updated name");
                    string newname = Console.ReadLine();
                    a.UpdateContactName(currentname, newname);

                }
                else if(input == "0") 
                    break;

            }
            
            //Console.WriteLine(c.DisplayRecord());

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook 
{
    internal class AddressBook
    {
        static AddressBook()
        {
            Console.WriteLine("Welcome to Address Book Program");
        }

       

        static void Main(string[] args)
        {

            AddressBook a = new AddressBook();

            List<Contacts> contactlist = new List<Contacts>();
            
            while (true)
            {
                
                Console.WriteLine("\nIf you want to add contact type 1");
                Console.WriteLine("If you want to display contact type 2");
                Console.WriteLine("If you want to close type 3");
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
                    foreach (Contacts contact in contactlist)
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine(contact.DisplayRecord());
                        Console.WriteLine("=========================================");
                    }
                }
                else if(input == "3") 
                    break;

            }
            
            //Console.WriteLine(c.DisplayRecord());

            
        }
    }
}

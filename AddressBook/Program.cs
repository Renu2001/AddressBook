namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook a = new AddressBook();
            Contacts contacts = new Contacts {FirstName = "Renuka", LastName = "Bagave", City = "Kankavli", State = "Maharashtra", ZipCode = 416602, Email = "renu.123@gmail.com",  PhoneNumber = 9425658955 };
            
            Console.WriteLine(contacts.Display());
        }
    }
}

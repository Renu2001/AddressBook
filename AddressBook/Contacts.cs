using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contacts 
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }

        public string Display()
        {
            return $"FirstName is : {FirstName} LastName is : {LastName} Address is : {Address} City is :{City} State is :{State} ZipCode is : {ZipCode} Email is : {Email} PhoneNumber is : {PhoneNumber}";
        }

       

        


    }
}

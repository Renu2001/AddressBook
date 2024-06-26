﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    internal class Contacts 
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }

        public void GetUserInfo()
        {
            Console.WriteLine("\nPlease enter your details :");
            Console.Write("FirstName :  ");
            this.FirstName = Console.ReadLine();
            Console.Write("LastName :  ");
            this.LastName = Console.ReadLine();
            Console.Write("Address :  ");
            this.Address = Console.ReadLine();
            Console.Write("City :  ");
            this.City = Console.ReadLine();
            Console.Write("State :  ");
            this.State = Console.ReadLine();
            Console.Write("ZipCode :  ");
            this.ZipCode = Convert.ToInt64(Console.ReadLine());
            Console.Write("Email :  ");
            this.Email = Console.ReadLine();
            Console.Write("PhoneNumber :  ");
            this.PhoneNumber = Convert.ToInt64(Console.ReadLine());
        }

        public string DisplayRecord()
        {
            return $"Your details are : \n\nFirstName is : {this.FirstName} \nLastName is : {this.LastName} \nAddress is : {this.Address} \nCity is :{this.City} \nState is :{this.State} \nZipCode is : {this.ZipCode} \nEmail is : {this.Email} \nPhoneNumber is : {this.PhoneNumber}";
        }

    }
}

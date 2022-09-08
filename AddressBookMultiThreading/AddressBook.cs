using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMultiThreading
{
    public class AddressBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public AddressBook(string Firstname, string Lastname, string Address, string City, string State, int Zip, long PhoneNumber, string Email)
        {
            this.FirstName = Firstname;
            this.LastName = Lastname;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;

        }
    }
}
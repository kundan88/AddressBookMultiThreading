using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookMultiThreading
{
    public class AddressBookOperations
    {
        public List<AddressBook> Addresslist = new List<AddressBook>();
        public void AddContacts(List<AddressBook> Addresslist)
        {
            Addresslist.ForEach(AddData =>
            {
                Console.WriteLine("Data being added: " + AddData.FirstName + " " + AddData.LastName + " " + AddData.Address + " " + AddData.City + " " + AddData.State + " " + AddData.Zip + " " + AddData.PhoneNumber + " " + AddData.Email);
                this.AddDetails(AddData);
                Console.WriteLine("Contact added: " + AddData.FirstName + " " + AddData.LastName + " " + AddData.Address + " " + AddData.City + " " + AddData.State + " " + AddData.Zip + " " + AddData.PhoneNumber + " " + AddData.Email);
            }
            );
            Console.WriteLine(this.Addresslist.ToString());
        }
        public void AddDetails(AddressBook address)
        {
            Addresslist.Add(address);
        }
    }
}
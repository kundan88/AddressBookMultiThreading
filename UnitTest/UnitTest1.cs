using System.Collections.Generic;
using System;
using NUnit.Framework;
using AddressBookMultiThreading;

namespace AddressBookTest
{
    public class Tests
    {
        List<AddressBook> AddressList;
        AddressBookOperations addressBookOperations;
        [SetUp]

        public void Setup()
        {
            AddressList = new List<AddressBook>();
            addressBookOperations = new AddressBookOperations();
        }

        [Test]
        public void CheckingTime_For_Inserting_Details()
        {
            AddressList.Add(new AddressBook(Firstname: "Sam", Lastname: "Hades", Address: "SanDiego", City: "Miami", State: "Florida", Zip: 124563, PhoneNumber: 9854632598, Email: "hades@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Rita", Lastname: "Harward", Address: "Buckhimgam", City: "London", State: "NewYork", Zip: 147856, PhoneNumber: 7742365898, Email: "harwardlucifer@gmail.com"));
            AddressList.Add(new AddressBook(Firstname: "Robbert", Lastname: "Escobar", Address: "BeverlyHills", City: "SanAndreas", State: "Washington", Zip: 136987, PhoneNumber: 8846932568, Email: "pablo@gmail.com"));

            // Without Thread
            DateTime StartDateTime = DateTime.Now;
            addressBookOperations.AddContacts(AddressList);
            DateTime StopDateTimes = DateTime.Now;
            Console.WriteLine("Duration without threads: " + (StopDateTimes - StartDateTime));

            //With Thread
            DateTime StartDateTimeThread = DateTime.Now;
            addressBookOperations.AddContactsThread(AddressList);
            DateTime StopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with threads: " + (StopDateTimeThread - StartDateTimeThread));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsDetails;
using Address;
using AddressBook;

namespace OOPS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book Program");
            AddressBookDictionary addressBookDictionary = new AddressBookDictionary();
            addressBookDictionary.AddMultipleAdressBook();
            addressBookDictionary.GetAddressBook();
            
        }
    }
}
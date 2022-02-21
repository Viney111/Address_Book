using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Address;
using ContactsDetails;

namespace AddressBook
{
    internal class AddressBookDictionary
    {
        Dictionary<string,Address_Book> _multipleAddressBook = new Dictionary<string,Address_Book>();

        public void AddAddressBook(string nameOfAddressBook,Address_Book address_Book)
        {
            _multipleAddressBook.Add(nameOfAddressBook,address_Book);
        }
        public void AddMultipleAdressBook()
        {
            Console.WriteLine("How manny address books u want?");
            int countAddressBook = Convert.ToInt32(Console.ReadLine());
            while(countAddressBook > 0)
            {
                string choiceToAddContacts = string.Empty;
                string nameofEditOrDeleteContact = string.Empty;
                string choiceToEditOrDelete = string.Empty;
                string nameOfAddressBook = string.Empty;
                Address_Book book = new Address_Book();
                //For Adding Contact Details
                do
                {
                    Contacts c = Contacts.AddContactFromConsole();
                    book.AddContacts(c);
                    Console.WriteLine("Do u want to add Contacts: - Y or N");
                    choiceToAddContacts = Console.ReadLine().ToUpper();
                } while (choiceToAddContacts != "N");
                Console.Write("Enter the name of Address Book: ");
                nameOfAddressBook = Console.ReadLine();
                AddAddressBook(nameOfAddressBook, book);
                countAddressBook--;
            }
        }
        public void GetAddressBook()
        {
            foreach(var pair in _multipleAddressBook)
            {
                Console.WriteLine($"Name of Address Book is {pair.Key} & details are: ");
                pair.Value.getContacts();
            }
        }
    }
}

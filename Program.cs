using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsDetails;
using Address;

namespace OOPS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book Program");
            //VARIABLES
            string choice = string.Empty;
            Address_Book book = new Address_Book();
            do
            {
                Contacts c =  Contacts.AddContact();
                book.AddContacts(c);
                Console.WriteLine("Do u want to add Contacts: - Y or N");
                choice = Console.ReadLine().ToUpper();
            } while(choice != "N");
            book.getContacts();
                
        }
    }
}
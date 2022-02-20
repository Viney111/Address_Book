using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsDetails;

namespace Address
{
    internal class Address_Book
    {
        List<Contacts> listOfContacts = new List<Contacts>();
        public void AddContacts(Contacts c)
        {
            listOfContacts.Add(c);
        }
        public void getContacts()
        {
            foreach (var v in listOfContacts)
            {
                Console.WriteLine($"First Name is {v.firstName}\nLast name is {v.lastName}\nPhone Number is {v.phoneNo}");
            }
        }
        
    }
}

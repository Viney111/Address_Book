using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Address_Book;

namespace OOPS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book Program");
            //Storing 2 Persons details in the list by Console
            Contacts p1 = new Contacts();
            p1.AddContact();
            Contacts p2 = new Contacts();
            p2.AddContact();
            List<Contacts> listOfContacts = new List<Contacts>();
            listOfContacts.Add(p1);
            listOfContacts.Add(p2);
        }
    }
}
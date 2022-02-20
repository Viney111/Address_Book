using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public double phoneNo { get; set; }
        public string eMail { get; set; }

        public void AddContact()
        {
            Console.Write("Enter first name: ");
            this.firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            this.lastName = Console.ReadLine();
            Console.Write("Enter address details: ");
            this.address = Console.ReadLine();
            Console.Write("Enter city name: ");
            this.city = Console.ReadLine();
            Console.Write("Enter state name: ");
            this.state = Console.ReadLine();
            Console.Write("Enter zip Code: ");
            this.zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter phone Number: ");
            this.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ebter your mail Id: ");
            this.eMail = Console.ReadLine();
            Console.WriteLine($"Details of{this.firstName} added successfully");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Person
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        public void DisplayFullName()
        {
            Console.WriteLine("Full Name is" + firstName + " " + lastName);
        }
        static void Main()
        {
            Person p1 = new Person();
            p1.firstName = "Shripad";
            p1.lastName = "Lokhande";
            p1.DisplayFullName();
        }
    }
}

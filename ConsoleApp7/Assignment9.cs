using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Show()
        {
            Console.WriteLine("First Name is" + FirstName);
            Console.WriteLine("Last name is" + LastName);
        }
        public void Display()
        {
            Console.WriteLine("Full Name is" + FirstName +" " + LastName);
        }
    }
    public class PublicExample
    {
        static void Main()
        {
            person obj = new person();
            obj.FirstName = "Shripad";
            obj.LastName = "Lokhande";
            obj.Show();
            obj.Display();
        }

    }
}

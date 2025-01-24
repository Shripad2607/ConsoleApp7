using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Out_Keyword
    {
        static void Main()
        {
            int number;
            string message;

            InitializeValues(out number, out message);

            Console.WriteLine("Number :" + number);
            Console.WriteLine("Message :" + message);
        }
        static void InitializeValues(out int number,out string message)
        {
            number = 42;
            message = "This is out Example";
        }
       
    }
}

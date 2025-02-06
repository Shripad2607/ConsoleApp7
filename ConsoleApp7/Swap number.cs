using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Swap_number
    {
        static void Main()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a ="+ a +" b="+ b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After swap a =" + a + " b=" + b);
        }
    }
}

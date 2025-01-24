using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class RefKeyword
    {
        static void IncrementValue(ref int number)
        {
            number++;
        }
        static void Main()
        {
            int value = 10;
            Console.WriteLine("original value :" + value);

            IncrementValue(ref value);
            Console.WriteLine("Incremented value :" + value);
        }
    }
}

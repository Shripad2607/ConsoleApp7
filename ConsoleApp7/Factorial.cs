using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Factorial
    {
        static void Main()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter any number");
            number = int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of number is " + fact);
        }
    }
}

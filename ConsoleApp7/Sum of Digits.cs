using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Sum_of_Digits
    {
        static void Main()
        {
            int n, sum = 0, m;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("sum is =" + sum);
        }
    }
}

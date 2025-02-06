using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Decimal_to_Binary
    {
        static void Main()
        {
            int n, i;
            int[] a = new int[10];
            Console.WriteLine("Enter the number to convert :");
            n = int.Parse(Console.ReadLine());
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Binary of given number =");
            for(i=1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

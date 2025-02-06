using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Armstrong_number
    {
        static void Main()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not a armstrong number");
            }
                

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Number_triangle
    {
        static void Main()
        {
            int i, j, k, l, n;
            Console.WriteLine("Enter the range=");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=n;j++)
                {
                    Console.WriteLine(" ");
                }
                for(k=1;k<=i;k++)
                {
                    Console.WriteLine(k);
                }
                for(l=1;l>=1;l--)
                {
                    Console.WriteLine(l);
                }
                Console.WriteLine("\n");
            }
        }
    }
}

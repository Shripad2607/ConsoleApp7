using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Fibonacci_triangle
    {
        static void Main()
        {
            int a = 0, b = 1, i, c, n, j;
            Console.WriteLine("Enter the limit");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                a = 0;
                b = 1;
                Console.WriteLine(b + "\t");
                for(j=1;j<1;j++)
                {
                    c = a + b;
                    Console.WriteLine(c + "\t");
                    a = b;
                    b = c;
                }
                Console.WriteLine("\n");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment12
    {
        static void Main()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine("prime numbers in the array:");
            foreach (int num in nums)
            {
                if (num > 1) //
                {
                    int isPrime = 1;
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.Write(num + " ");
                    }
                }
            }     
        }
    }
}

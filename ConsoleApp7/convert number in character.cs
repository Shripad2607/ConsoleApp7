using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class convert_number_in_character
    {
        static void Main()
        {
            int n, sum = 0, r;
            Console.WriteLine("Enter the number = ");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            n = sum;
            while(n>0)
            {
                r = n % 10;
                switch (r)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:
                        Console.WriteLine("tttt");
                        break;
                }
                n = n / 10;
            }
        }
    }
}

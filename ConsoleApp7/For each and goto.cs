using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment4
    //display list of 10 mobile brands using foreach
    {
        static void Main()
        {
            string[] MobileBrands = { "apple", "samsung", "oppo", "vivo", "nokia", "motorola", "one+", "redmi", "intel", "honor" };
            foreach (string mobilebrand in MobileBrands)
            {
                Console.WriteLine("Mobile brand is" + mobilebrand);
            }

            //continue statements
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            //goto statements
            int age = 100;
        startloop:
            if (age >= 0 && age <= 120)
            {
                Console.WriteLine($"age is {age}");
                age++;
                goto startloop;
                Console.WriteLine($"after go to age is {age}");
            }
            Console.WriteLine("end of go to loop");
        }
    }
}

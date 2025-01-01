using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp7
{
    internal class Assignment6
    {
        //even no and odd no
        static void Main()
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int evencount = 0;
            int oddcount = 0;

            foreach (int number in Numbers)

            {
                if (number % 2 == 0)
                {

                    evencount++;
                }
                else
                {

                    oddcount++;
                }
            }
            Console.WriteLine("Number of even integers :" + evencount);
            Console.WriteLine("Number of odd integers :" + oddcount);

        }





    }
}

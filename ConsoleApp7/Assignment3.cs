using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment3
    {
        static void Main()
        //basic condition
        {
            int number = 0;
            if (number > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is zero");
            }


            //Grade Calculator
            int Marks = 16;

            if (Marks >= 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (Marks >= 60)
            {
                Console.WriteLine("B Grade");
            }
            else if (Marks >= 40)
            {
                Console.WriteLine("C Grade");
            }
            else if (Marks >= 20)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("F Grade");
            }


        }
    }
}

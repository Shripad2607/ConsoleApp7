using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Exception_Handling_2
    {
        static void Main()
        {
            //Divided by zero exception
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = checked(num1 / num2);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("can not divide by zero");
            }
            //overflow exception
            try
            {
                int num1 = int.MaxValue;
                int result = checked(num1 + 1);
                Console.WriteLine(result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("can not add number");
            }

            //format exception
            try
            {
                string validDate = "2025-1-1";
                DateTime Date = DateTime.Parse(validDate);
                Console.WriteLine(Date);
                string invalidDate = "not-a-valid";
                DateTime inDate = DateTime.Parse(invalidDate);
                Console.WriteLine(inDate);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid date format");
            }
        }
    }
}

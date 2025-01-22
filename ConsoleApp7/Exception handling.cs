using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Exception_handling
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number :");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second :");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Addition :" + (num1 + num2));
                Console.WriteLine("subtraction :" + (num1 - num2));
                Console.WriteLine("Multiplication :" + (num1 * num2));

                //Division with exception handling
                Console.WriteLine("Division :" + (num1 / num2));
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error : Divided by zero is not allowed");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Error : Number is too large or too small");
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("Error : An arithmatic error occured");
            }
            catch(FormatException)
            {
                Console.WriteLine("Error : Invalid input.please enter valid number :");
            }
        }
    }
}

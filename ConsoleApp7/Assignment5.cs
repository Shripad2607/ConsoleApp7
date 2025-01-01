using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment5
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("The sum of the array elements is" + sum);

            // average of an array elements

            int[] Numbers = { 10, 20, 30, 40, 50 };
            int summation = 0;
            float average = 0.0f;

            foreach (int number in Numbers)
            {
                summation += number;
            }
            average = summation / Numbers.Length;
            Console.WriteLine("the Average is" + average);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp7
{
    internal class Assignment7
    {
        static void Main()
        {
            //initialize a string builder and append multiple string
            string str = "hello world";
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello world    ");
            sb.Append("welcome to   programming   ");
            sb.Append("The current year is : 2024    ");

            //replace string
            sb.Replace("Hello", "hi");
            Console.WriteLine("After Replace :" + sb.ToString());

            //remove
            //sb.remove(3,3)

            //insert
            sb.Insert(23, "c#");
            Console.WriteLine("After insert:" + sb.ToString());

            //console.writeline(sb.Tostring());
            sb.Clear();




            //max and min value in array
            int[] values = { 50, 30, 80, 10, 40 };
            int Max = values[0];
            int Min = values[0];
            foreach (int number in values)
            {
                if (number > Max)
                    Max = number;
                if (number < Min)
                    Min = number;
            }
            Console.WriteLine("The maximum value is :" + Max);
            Console.WriteLine("The minimum value is :" + Min);



            //search for elements
        }

    }
}

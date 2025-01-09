using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public float add(float c,float d)
        {
            return c + d;
        }
    }
    internal class staticpolymorphism
    {
        public static void Main()
        {
            calculator cal = new calculator();

            int sum = cal.add(4, 2);
            float sum1 = cal.add(5, 2);
            Console.WriteLine("sum of first method" + sum);
            Console.WriteLine("sum of second method" + sum1);
        }
    }
}

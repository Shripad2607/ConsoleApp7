using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class operation
    {
        public delegate void Multioperation(int x, int y);
        public static void Addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void subtraction(int x,int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Multiplication(int x,int y)
        {
            Console.WriteLine(x * y);
        }
    }
    internal class MulticastDelegate
    {
        static void Main()
        {
            operation.Multioperation Operation = operation.Addition;
            Operation += operation.subtraction;
            Operation += operation.Multiplication;
            Console.WriteLine("Multicast Delegate :");
            Operation(23, 34);
        }
    }
}

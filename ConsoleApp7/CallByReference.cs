using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program1
    {
        public void show(ref int val)
        {
            val*= val;
            Console.WriteLine("Value inside show function " + val);
        }
        static void Main()
        {
            int val = 50;
            Program1 Program = new Program1();
            Console.WriteLine("Value before calling function " + val);
            Program.show(ref val);
            Console.WriteLine("values after calling function " + val);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("Value inside show function" + val);
        }
        static void Main()
        {
            int val = 50;
            Program Program = new Program();
            Console.WriteLine("Value before calling function" + val);
            Program.show(val);
            Console.WriteLine("value after calling function" + val);
        }
    }
}

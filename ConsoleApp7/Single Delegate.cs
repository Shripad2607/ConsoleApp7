using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class MyDelegate
    {
       public void Addition(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public void subtraction(int x,int y)
        {
            Console.WriteLine(x - y);
        }
    }
    internal class DelegateAssignment
    {
        public delegate void operations(int x, int y);
        static void Main()
        {
            MyDelegate myDelegate = new MyDelegate();
            operations additionDelegate = myDelegate.Addition;

            operations subtractionDelegate = myDelegate.subtraction;
            Console.WriteLine("Addition :");
            additionDelegate(10, 5);

            Console.WriteLine("subtraction :");
            subtractionDelegate(10, 5);
        }
    }
}

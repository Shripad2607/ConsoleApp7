using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class collection
    {
        static void Main()
        {
            Stack<object>stack = new Stack<object>();
            stack.Push(1);
            stack.Push("hello");
            stack.Push(123456789);
            stack.Push(false);
            stack.Push(5.5);
            Console.WriteLine("Total elements from stack");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("removed elements from stack");
            object firstElement = stack.Pop();
            object secondElement = stack.Pop();
            object thirdElement = stack.Pop();
            object fourthElement = stack.Pop();
            object fifthElement = stack.Pop();

            Console.WriteLine(firstElement);
            Console.WriteLine(secondElement);
            Console.WriteLine(thirdElement);
            Console.WriteLine(fourthElement);
            Console.WriteLine(fifthElement);

            Console.WriteLine("Is stack empty :" + (stack.Count == 0));

        }
    }
}

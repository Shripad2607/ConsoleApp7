using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment2
    {
        static void Main()

        {
            int a = 20;
            int b = 10;
            //Arithmatic Oprator
            Console.WriteLine("Arithmatic");
            Console.WriteLine($"Addition {a + b}");
            Console.WriteLine($"Substraction {a - b}");
            Console.WriteLine($"Multiplication {a * b}");
            Console.WriteLine($"Division {a / b}");
            Console.WriteLine($"Mode {a % b}");

            int x = 20;
            int y = 5;

            //relational oprator 
            Console.WriteLine("Relational operator");
            Console.WriteLine($"x==y {x == y}");
            Console.WriteLine($"x!=y {x != y}");
            Console.WriteLine($"x is greater than y {x > y}");
            Console.WriteLine($"x is less than y {x < y}");
            Console.WriteLine($"x is greater than equal to y {x >= y}");
            Console.WriteLine($"x is less than equal to y {x <= y}");


            bool p = true;
            bool q = false;
            //Logical Oprator
            Console.WriteLine("Logical oprator");
            Console.WriteLine($"p && q {p && q}");
            Console.WriteLine($"p || q {p || q}");
            Console.WriteLine($"!p {!p}");
            Console.WriteLine($"!q {!q}");
        }
    }
}




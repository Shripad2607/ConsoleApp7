using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  class shape1
    {
        public string color = "";
        public void DisplayDetails()
        {
            Console.WriteLine(color);
        }
    }
    class rectangle1 : shape1
    {
        public rectangle1(string color)
        {
            this.color = color;
        }
    }
    class circle1 : shape1
    {
        public circle1(string color)
        {
            this.color = color;
        }
    }
    internal class HierarchicalInheritance
    {
        static void Main()
        {
            circle1 c = new circle1("Gray");
            Console.WriteLine("circle color is :");
            c.DisplayDetails();
            
            rectangle1 r = new rectangle1("pink");
            Console.WriteLine("rectangle color is :");
            r.DisplayDetails();

        }
        


         
    }
}

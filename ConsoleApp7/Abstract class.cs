using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class shape
    {
        //abstract method
        public abstract double calculateArea();
    
        //Non abstract method
        public virtual void Display()
        {
            Console.WriteLine("This is shape");
        }
    }
    class Rectangle : shape
    {
        private double length;
        private double width;
        //constructor
        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        //override calculatearea method
        public override double calculateArea()
        {
            return length * width;
        }
        public override void Display()
        {
            Console.WriteLine($"This is rectangle with length {length} and width {width}");
        }
    }
    class circle : shape
    {
        private double radius;
        //constructor
        public circle(double radius)
        {
            this.radius = radius;
        }
        //override calculate method
        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Display()
        {
            Console.WriteLine($"This is circle with Radius {radius}");
        }
    }
    internal class AbstractExample
    {
        static void Main()
        {
            //create an object
            Rectangle r1 = new Rectangle(5, 6);
            circle c1 = new circle(4);

            r1.Display();
            Console.WriteLine($"Area of rectangle is :{r1.calculateArea()}");

            c1.Display();
            Console.WriteLine($"Area of circle is :{c1.calculateArea()}");
        }
    }
}

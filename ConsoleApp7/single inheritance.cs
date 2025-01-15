using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
     class person4
    {
        public string name;
        public int age;
    }
    class student : person4
    { 
        public student(string n,int a)
        {
            name = n;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine($"name is : {name}");
            Console.WriteLine($"age is :{age}");
        }
            
    }
    internal class singleinheritance
    {
        static void Main()
        {
            student s = new student("Shripad", 23);
            s.Display();
        }
    }

}

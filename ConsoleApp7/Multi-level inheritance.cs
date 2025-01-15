using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    class person5
    {
        public int id;
        public int salary;
        public string Name;
        public string Address;
    }
    class Teacher : person5
    {
        public int id;
        public int salary;
    }
    class Teachersalary:Teacher
    {
        int basic;
        int gross;

        public Teachersalary(string name,string address,int id, int salary,int basic,int gross)
        {
            this.Name = name;
            this.Address = address;
            this.id = id;
            this.salary = salary;
            this.basic = basic;
            this.gross = gross;
        }
        public void Display()
        {
            Console.WriteLine($"Name is :{Name}");
            Console.WriteLine($"Addess is :{Address}");
            Console.WriteLine($"Id is :{id}");
            Console.WriteLine($"salary is :{salary}");
            Console.WriteLine($"Basic is :{basic}");
            Console.WriteLine($"Gross is :{gross}");
        }
    }
    internal class multilevelinheritance
    {
        static void Main()
        {
            Teachersalary t = new Teachersalary("shripad", "maharastra", 1805, 40000, 2000, 10000);
            t.Display();
        }
    }
}

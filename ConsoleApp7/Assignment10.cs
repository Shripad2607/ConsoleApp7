using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class person1
    {
        protected int employeeId;
        protected string EmployeeName;
        protected string Address;
    }
    class Employee : person1
    {
        public void setDetails(int id, string name, string adr)
        {
            employeeId = id;
            EmployeeName = name;
            Address = adr;
        }
        public void displayDetails()
        {
            Console.WriteLine("Employee id is" + employeeId);
            Console.WriteLine("Employee Name is" + EmployeeName);
            Console.WriteLine("Employee address is" + Address);
        }
    }
    internal class protectedExample
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.setDetails(101, "ABC", "Pune");
            emp.displayDetails();
        }
    }
}

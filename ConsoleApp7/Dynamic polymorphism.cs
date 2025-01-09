using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started");
        }
        //derived class
        class car : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Car engine started");
            }
        }
        //derived class 2
        class Truck : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Truck engine started");
            }
        }
        internal class DynamicBinding
        {
             static void Main()
            {
                Vehicle s1 = new Vehicle();
                Vehicle s2 = new car();
                Vehicle s3 = new Truck();

                s1.StartEngine();
                s2.StartEngine();
                s3.StartEngine();
            }
        }
    }
}

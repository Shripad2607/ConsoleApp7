using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    static class catworld
    {
        public static int noofcats { get; private set; }
        public static int totalcatnaps { get; private set; }

        static catworld()
        {
            noofcats = 10;
            totalcatnaps = 10;
        }
        public static void Addcat()
        {
            noofcats++;
            Console.WriteLine("The new cat has joined the world ! Total cats :" + noofcats);
        }
    }
    internal class staticclassassignment
    {
        static void Main()
        {
            Console.WriteLine($"Initial number of cats :{catworld.noofcats}");
            catworld.Addcat();
            Console.WriteLine($"Current number of cats :{catworld.noofcats}");
        }
    }
}

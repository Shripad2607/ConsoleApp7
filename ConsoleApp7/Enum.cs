using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Assignment8
    {
       
        enum Year
        {
            jan,feb,mar,apr,may,jun,jul,aug,sep,oct,nov,dec
        }
         static void Main()
        {
            Month(Year.jan);
            Month(Year.dec);
        }
        static void Month(Year month)
        {
            switch(month)
            {
                case Year.jan:
                    Console.WriteLine("jan is a starting month of year");
                    break;

                case Year.dec:
                    Console.WriteLine("Dec is a ending month of year");
                    break;
            }
        }
    }
}

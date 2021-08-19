using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
       
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
            public bool IsItALeapYear(int year)
            {
                if ((year % 4 == 0) && (year % 100 != 0))
                {
                    return true;
                }
                if (year % 400 == 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }   
    }
}

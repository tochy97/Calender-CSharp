using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class Calculations
    {
        List<Year> years;
        int start;
        int end;
        public static bool IsYearLeap(int year)
        {
            return year % 4 == 0;
        }
        public Year GetYear(int year)
        {
            System.Console.WriteLine("Getting year: " + year);
            return new Year();
        }
    }
}

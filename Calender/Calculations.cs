using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class Calculations
    {
        public struct _Calender
        {
            List<_Year> years;
        }
        public Month GetCalender() 
        {
            return new Month();
        }

        public Year GetYear(int year)
        {
            System.Console.WriteLine("Getting year: " + year);
            return new Year();
        }
    }
}

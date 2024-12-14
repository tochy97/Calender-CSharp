using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public struct _Year
    {
        public int index;
        public List<_Month> months;
        public bool isLeap;
    }
    public class Year
    {
        public _Year self;

        public static bool IsYearLeap(int year)
        {
            return year % 4 == 0;
        }

        public _Year Calculate (int year)
        {
            return self;
        }

    }
}

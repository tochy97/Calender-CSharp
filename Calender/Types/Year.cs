using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender.Types
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

        public bool IsYearLeap(int year)
        {
            return year % 4 == 0;
        }

        public

    }
}

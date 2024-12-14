using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public struct _Week
    {
        List<_Day> days;
        int index;
    }

    public class Week
    {
        public _Week self;

        public _Week Calculate(int day_index, string day_name, int max_month_index)
        {
            return self;
        }
    }
}

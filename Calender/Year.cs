using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class Year
    {
        public int index;
        public List<Month> months;
        public bool isLeap;

        public Year self;
        public Year Get ()
        {
            return self;
        }

        public List<Month> Calculate (int year)
        {
            List<Month> months = new List<Month>();
            return months;
        }

    }
}

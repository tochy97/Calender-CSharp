using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public struct _Timestamp
    {
        public string input;
        public Day day;
        public Month month;
        public Year year;
    }
    internal class Timestamps
    {
        public _Timestamp self;

        public Day ParseDay(string input)
        {
            return new Day();
        }

        public Month ParseMonth(string input)
        {
            return new Month();
        }

        public Year ParseYear(string input)
        {
            return new Year();
        }
        public Timestamps(string input)
        {
            self.input = input;
        }
        public void StringtoXml(string input)
        {

        }

        public void StringToJson(string input) 
        {
        
        }

    }
}

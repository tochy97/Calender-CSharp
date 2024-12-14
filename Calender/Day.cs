using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{

    public struct _Day
    {
        public string name;
        public int index;
    }
    public class Day
    {
        public static readonly string[] values =
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        public _Day self;
        public static _Day MakeSunday(int value, string day)
        {
            if (value <= -7)
            {
                value += 7;
            }
            switch (day)
            {
                case "Monday":
                    value -= 1;
                    break;
                case "Tuesday":
                    value -= 2;
                    break;
                case "Wednesday":
                    value -= 3;
                    break;
                case "Thursday":
                    value -= 4;
                    break;
                case "Friday":
                    value -= 5;
                    break;
                case "Saturday":
                    value -= 6;
                    break;
                default:
                    break;
            }
            return new _Day
            {
                name = "Sunday",
                index = value
            };
        }

        public static string GetNextDay(string name)
        {
            int position = Array.IndexOf(values, name) + 1;
            if (position == -1)
            {
                position = 0;
            }
            return values[position];
        }

        public static string GetPrevDay(string name)
        {
            int position = Array.IndexOf(values, name) - 1;
            if (position == -1)
            {
                position = 6;
            }
            return values[position];
        }

    }
}

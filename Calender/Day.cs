using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calender
{

    public struct _Day
    {
        public string name;
        public int index;
    }
    public class Day
    {
        public _Day self;
        public Day (string name, int index)
        {
            self.name = name;
            self.index = index;
        }

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

        public static _Day CalcNextDay(string name, int index, int maxMonthIndex)
        {
            int position = Array.IndexOf(values, name) + 1;
            if (position == -1)
            {
                position = 0;
            }
            index = index + 1;
            name = values[position];
            if (index > maxMonthIndex)
            {
                index = -1;
            }
            return new _Day
            {
                name = name,
                index = index
            };
        }

        public bool MakeNextDay(int maxMonthIndex)
        {
            _Day result = CalcNextDay(self.name, self.index, maxMonthIndex);
            if (result.index == -1)
            {
                return false;
            }
            self.name = result.name;
            self.index = result.index;
            return true;
        }
        public static _Day CalcPrevDay(string name, int index)
        {
            int position = Array.IndexOf(values, name) - 1;
            if (position == -1)
            {
                position = 6;
            }
            index = index + 1;
            name = values[position];
            if (index == 0)
            {
                index = -1;
                name = "";
            }
            return new _Day
            {
                name = name,
                index = index
            };
        }

        public bool MakePrevDay()
        {
            _Day result = CalcPrevDay(self.name, self.index);
            if (result.index == -1)
            {
                return false;
            }
            self.name = result.name;
            self.index = result.index;
            return true;
        }
    }
}

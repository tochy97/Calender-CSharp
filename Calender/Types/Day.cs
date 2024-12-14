using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender.Types
{

    public struct _Day
    {
        public string name;
        public int index;
    }
    public class Day
    {
        public static readonly string[] value =
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

        public string GetNextDay(string name)
        {
            switch (name)
            {
                case "Monday":
                    return "Tuesday";
                case "Tuesday":
                    return "Wednesday";
                case "Wednesday":
                    return "Thursday";
                case "Thursday":
                    return "Friday";
                case "Friday":
                    return "Saturday";
                case "Saturday":
                    return "Sunday";
                case "Sunday":
                    return "Monday";
                default:
                    return "";
            }
        }

        public string GetPrevDay(string name)
        {
            switch (name)
            {
                case "Monday":
                    return "Sunday";
                case "Tuesday":
                    return "Monday";
                case "Wednesday":
                    return "Tuesday";
                case "Thursday":
                    return "Wednesday";
                case "Friday":
                    return "Thursday";
                case "Saturday":
                    return "Friday";
                case "Sunday":
                    return "Saturday";
                default:
                    return "";
            }
        }
    }
}

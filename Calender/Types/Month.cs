using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender.Types
{
    public struct _Month
    {
        public int index;
        public string name;
        public List<_Day> days;
    }
    public class Month
    {
        public _Month self;
        public static readonly string[] value = 
        { 
            "January", 
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December" 
        };

        public int GetMonthMax (int index, bool leap)
        {
            switch (index)
            {
                case 1:
                    // Febuary
                    if (leap)
                    {
                        return 29;
                    }
                    return 28;
                case 3:
                    // April
                    return 30;
                case 5:
                    // June
                    return 30;
                case 8:
                    // September
                    return 30;
                case 10:
                    // November
                    return 30;
                default:
                    // Others
                    return 31;
            }
        }

        public string GetNextMonth (string name)
        {
            switch (name)
            {
                case "January":
                    return "Febuary";
                case "Febuary":
                    return "March";
                case "March":
                    return "April";
                case "April":
                    return "May";
                case "May":
                    return "June";
                case "June":
                    return "July";
                case "July":
                    return "August";
                case "August":
                    return "September";
                case "September":
                    return "October";
                case "October":
                    return "November";
                case "November":
                    return "December";
                case "December":
                    return "January";
                default:
                    return "";
            }
        }

        public string GetPreviousMonth (string name)
        {
            switch (name)
            {
                case "January":
                    return "December";
                case "Febuary":
                    return "January";
                case "March":
                    return "Febuary";
                case "April":
                    return "March";
                case "May":
                    return "April";
                case "June":
                    return "May";
                case "July":
                    return "June";
                case "August":
                    return "July";
                case "September":
                    return "August";
                case "October":
                    return "September";
                case "November":
                    return "October";
                case "December":
                    return "November";
                default:
                    return "";
            }
        }
    }
}

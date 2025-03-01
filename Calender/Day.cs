using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calender
{
    public class Day
    {
        public struct _Day
        {
            public string name;
            public int index;
            public int week_index;
        }
        public string name;
        public int index;
        public int week_index;
        public int month;
        public int year;
        private DateTime today = DateTime.Today;
        public Day ()
        {
            this.index = today.Day;
            this.name = today.DayOfWeek.ToString();
            this.week_index = Array.IndexOf(Constants.WeekNames, name);
            this.month = today.Month;
            this.year = today.Year;
        }
        public Day (string name)
        {
            this.name = name;
            this.week_index = Array.IndexOf(Constants.WeekNames, this.name);
            this.index = CalcIndexFromName(name, week_index);
            this.month = today.Month;
            this.year = today.Year;
        }
        public Day(string name, int month, int year)
        {
            this.name = name;
            this.week_index = Array.IndexOf(Constants.WeekNames, this.name);
            this.index = CalcIndexFromName(name, week_index);
            this.month = month;
            this.year = year;
        }
        public Day(string name, int index, int month, int year)
        {
            this.name = name;
            this.week_index = Array.IndexOf(Constants.WeekNames, this.name);
            this.index = index;
            this.month = month;
            this.year = year;
        }
        private int CalcIndexFromName(string name, int week_index)
        {
            int today_index = today.Day;
            string today_name = today.DayOfWeek.ToString();
            int today_week_index = Array.IndexOf(Constants.WeekNames, today_name);
            return today_index + (week_index - today_week_index);
        }
        private static _Day NextDay(string name, int index)
        {
            int position = Array.IndexOf(Constants.WeekNames, name) + 1;
            if (position == -1)
            {
                position = 0;
            }
            return new _Day
            {
                name = Constants.WeekNames[position],
                index = index + 1,
                week_index = position
            };
        }
        public void MakeNextDay()
        {
            _Day new_day = NextDay(this.name, this.index);
            int maxMonthIndex = Constants.MonthMax[this.month - 1];
            if (new_day.index > maxMonthIndex)
            {
                throw new ArgumentOutOfRangeException("Month");
            }
            this.name = new_day.name;
            this.index = new_day.index;
            this.week_index = new_day.week_index;
        }
        private _Day PrevDay(string name, int index)
        {
            int position = Array.IndexOf(Constants.WeekNames, name) - 1;
            if (position == -1)
            {
                position = 6;
            }
            return new _Day
            {
                name = Constants.WeekNames[position],
                index = index - 1,
                week_index = position
            };
        }
        public void MakePrevDay()
        {
            _Day new_day = PrevDay(this.name, this.index);
            if (new_day.index < 1)
            {
                throw new ArgumentOutOfRangeException("Month");
            }
            this.name = new_day.name;
            this.index = new_day.index;
            this.week_index = new_day.week_index;
        }
    }
}

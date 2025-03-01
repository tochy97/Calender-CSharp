﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class Month
    {
        public int index;
        public string name;
        public List<Day> days;
        public static readonly string[] values = 
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
        public Month (string name, int index, int day_index, string day_name, bool leap)
        {
            this.name = name;
            this.index = index;
            //this.days = Calculate(day_index, day_name, index, leap);
        }

        //public Month (Day day)
        //{
        //    days = Calculate(day.index);
        //}
        public static int GetMonthMax (int index, bool leap)
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

        public static string GetNextMonth (string name)
        {
            int position = Array.IndexOf(values, name) + 1;
            if (position == -1)
            {
                position = 0;
            }
            name = values[position];
            return name;
        }

        public static string GetPreviousMonth (string name)
        {
            int position = Array.IndexOf(values, name) - 1;
            if (position == -1)
            {
                position = 11;
            }
            name = values[position];
            return name;
        }

        //public static List<Day> Calculate(int day_index, string day_name, int month_index, bool leap)
        //{
        //    List<Day> days = new List<Day>();
        //    Day day = new Day(day_name, day_index);
        //    int maxIndex = GetMonthMax(month_index, leap);
        //    days.Add(day);
        //    // Going forward
        //    while (day.MakeNextDay(maxIndex))
        //    {
        //        days.Add(day);
        //    }
        //    day = new Day
        //    {
        //        name = day_name,
        //        index = day_index
        //    };
        //    // Going backward
        //    while (day.MakePrevDay())
        //    {
        //        days.Add(day);
        //    }
        //    return days;
        //}

        public bool MakePrevMonth()
        {
            return true;
        }
        public bool MakeNextMonth()
        {
            return true;
        }

    }
}

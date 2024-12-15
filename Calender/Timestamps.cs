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

    public struct _Date
    {
        public int year;
        public int month;
        public int day;
    }

    internal struct _Finder
    {
        public int index;
        public bool found;
    }
    internal class Timestamps
    {
        public _Timestamp self;

        private static readonly char[] delimiters =
        {
            '-',
            '/',
        };

        internal _Finder FindIndex(string[] words, char type)
        {
            int index = 0;
            _Finder find = new _Finder {
                index = -1,
                found = false,
            };
            while (index < words.Length) {
                switch (type)
                {
                    case 'Y':
                        if (int.TryParse(words[index], out int value) && words[index].Length == 4)
                        {
                            find.found = true;
                            find.index = index;
                        }
                        break;
                    case 'M':
                        break;
                    case 'D':
                        break;
                }
                index++;
            }
            return find;
        }


        internal _Date ParseDate(string input)
        {
            _Date date = new _Date();
            int i = 0;
            string[] words = input.Split(' ');
            while (words.Length == 1)
            {
                words = input.Split(delimiters[i]);
                i++;
            }
            if (words.Length == 3)
            {

            }
            return date;
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

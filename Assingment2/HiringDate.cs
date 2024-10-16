using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment2
{
    /// <summary>
    /// HiringDate represent a date consists of day, month, and year.
    /// </summary>
    public struct HiringDate
    {
        private int _day;
        public int Day 
        { 
            set
            {
                if (value <= 0 || value > 31)
                    throw new Exception();

                _day = value;
            }
            get => _day;      
        }

        private int _month;
        public int Month 
        {
            set
            {
                if (value <= 0 || value > 12)
                    throw new Exception();
                _month = value;
            }
            get => _month;
        }

        private int _year;
        public int Year 
        {
            set
            {
                if (value < 1960 || value > DateTime.Now.Year)
                    throw new Exception();

                _year = value;
            }
            get => _year;

        }

        public override string ToString()
            => $"{Day}/{Month}/{Year}";
    }
}

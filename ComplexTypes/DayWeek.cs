using System;

namespace Solidex.Core.Base.ComplexTypes
{
    public class DayWeek : IComparable<DayOfWeek>
    {
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public int CompareTo(DayOfWeek other)
        {
            switch (other)
            {
                case DayOfWeek.Monday:
                    return Monday ? 0 : -1;
                case DayOfWeek.Saturday:
                    return Saturday ? 0 : -1;
                case DayOfWeek.Friday:
                    return Friday ? 0 : -1;
                case DayOfWeek.Sunday:
                    return Sunday ? 0 : -1;
                case DayOfWeek.Thursday:
                    return Thursday ? 0 : -1;
                case DayOfWeek.Tuesday:
                    return Tuesday ? 0 : -1;
                case DayOfWeek.Wednesday:
                    return Wednesday ? 0 : -1;
            }

            return -1;
        }
    }
}
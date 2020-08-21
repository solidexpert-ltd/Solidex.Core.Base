using System;

namespace Solidex.Core.Base.ComplexTypes
{
    public class MonthYear: IComparable<int>
    {
        public bool January { get; set; }
        public bool February { get; set; }
        public bool March { get; set; }
        public bool April { get; set; }
        public bool May { get; set; }
        public bool June { get; set; }
        public bool July { get; set; }
        public bool August { get; set; }
        public bool September { get; set; }
        public bool October { get; set; }
        public bool November { get; set; }
        public bool December { get; set; }


        public int CompareTo(int other)
        {
            switch (other)
            {
                case 1: return January ? 0 : -1;
                case 2: return February ? 0 : -1;
                case 3: return March ? 0 : -1;
                case 4: return April ? 0 : -1;
                case 5: return May ? 0 : -1;
                case 6: return June ? 0 : -1;
                case 7: return July ? 0 : -1;
                case 8: return August ? 0 : -1;
                case 9: return September ? 0 : -1;
                case 10: return October ? 0 : -1;
                case 11: return November ? 0 : -1;
                case 12: return December ? 0 : -1;

                default: return -1;
            }
        }
    }
}
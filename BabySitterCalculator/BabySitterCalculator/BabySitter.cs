using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalculator
{
    public class BabySitter
    {
        private int startTime;

        public BabySitter(int startTime)
        {
            this.startTime = this.AdjustTimeIn24HoursFormat(startTime);
        }
        public int GetStartTime()
        {
            return this.startTime;
        }

        public int GetBedTime()
        {
            return 2;
        }

        public int GetEndTime()
        {
            return 3;
        }
        public int Calculate()
        {
            return 0;
        }

        private int AdjustTimeIn24HoursFormat(int hour)
        {
            if (hour >= 0 && hour <= 4)
            {
                hour += 24;
            }
            return hour;
        }
    } 
}

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
        private int endTime;
        private int bedTime;

        public BabySitter(int startTime, int endTime, int bedTime)
        {
            this.startTime = this.AdjustTimeIn24HoursFormat(startTime);
            this.endTime = this.AdjustTimeIn24HoursFormat(endTime);
            this.bedTime = this.AdjustTimeIn24HoursFormat(bedTime);
        }
        public int GetStartTime()
        {
            return this.startTime;
        }

        public int GetBedTime()
        {
            return this.bedTime;
        }

        public int GetEndTime()
        {
            return this.endTime;
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

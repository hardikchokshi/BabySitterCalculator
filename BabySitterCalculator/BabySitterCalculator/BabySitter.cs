using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalculator
{
    public class BabySitter
    {
        public static readonly int START_TIME = 17;
        public static readonly int END_TIME = 4;
        public static readonly int DEFAULT_BED_TIME = 21;

        private static readonly int REGULAR_RATE = 12;

        private int startTime;
        private int endTime;
        private int bedTime;

        public BabySitter(int startTime, int endTime, int bedTime)
        {
            this.ValidateStartAndEndTime(startTime, endTime);
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
        public int PaymentCalculator()
        {
            return (REGULAR_RATE) * (startTime - endTime);
        }

        private int AdjustTimeIn24HoursFormat(int hour)
        {
            if (hour >= 0 && hour <= 4)
            {
                hour += 24;
            }
            return hour;
        }

        private void ValidateStartAndEndTime(int startTime, int endTime)
        {
            if (startTime < START_TIME && startTime > END_TIME)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (endTime < START_TIME && endTime > END_TIME)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    } 
}

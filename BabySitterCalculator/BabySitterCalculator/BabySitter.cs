﻿using System;
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
        private static readonly int AFTERBED_TO_TILL_MIDNIGHT = 8;
        private static readonly int AFTER_MIDNIGHT_RATE = 16;

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
            return startTime >= 24 ? (AFTER_MIDNIGHT_RATE) * GetHoursAfterMidnightToEnd() :
                                     (REGULAR_RATE) * GetHoursTillBedTime()
                                    + (AFTERBED_TO_TILL_MIDNIGHT) * GetHoursAfterBedTimeToMidNight()
                                    + (AFTER_MIDNIGHT_RATE) * GetHoursAfterMidnightToEnd();
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

        private int GetHoursTillBedTime()
        {
            if (endTime < bedTime)
            {
                return endTime - startTime;
            }
            if(startTime > bedTime)
            {
                //return startTime - bedTime;
                return 0;
            }

            return bedTime - startTime;
        }

        private int GetHoursAfterBedTimeToMidNight()
        {
            if (endTime < bedTime)
            {
                return 0;
            }
            if (endTime < 24)
            {
                return endTime - bedTime;
            }
            if(startTime > bedTime)
            {
                return 24 - startTime;
            }

            return 24 - bedTime;
        }

        private int GetHoursAfterMidnightToEnd()
        {
            if(endTime <= 24)
            {
                return 0;
            }
            if(startTime > 24)
            {
                return (24- startTime) + (endTime - 24);
            }
            else
            {
                return endTime - 24;
            }

        }


    }
}

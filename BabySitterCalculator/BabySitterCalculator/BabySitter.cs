using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalculator
{
    public class BabySitter
    {
        public int GetStartTime()
        {
            return 1;
        }

        public int GetBedTime()
        {
            return 2;
        }

        public int GetEndTime()
        {
            return 3;
        }
        public int Calculate(int startTime, int endTime , int bedTime)
        {
            return startTime * endTime * bedTime;
        }
    }
}

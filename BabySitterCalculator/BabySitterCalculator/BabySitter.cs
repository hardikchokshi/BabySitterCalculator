using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterCalculator
{
    public class BabySitter
    {
        public int Calculate(int startTime, int endTime , int bedTime)
        {
            return startTime * endTime * bedTime;
        }
    }
}

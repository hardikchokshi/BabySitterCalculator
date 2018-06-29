using System;
using BabySitterCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BabySitterCalculation.Test
{
    [TestClass]
    public class BabySitterTest
    {
        BabySitter babySitter;

        [TestInitialize]
        public void Init()
        {
           babySitter = new BabySitter();
        }

        [TestMethod]
        public void BabySitterCalculatorWhenCalledReturnInt()
        {
            Assert.AreEqual(6, babySitter.Calculate(1, 2, 3));
        }

        public void BabySitterWhencCalledStartTimeReturnInt()
        {
            Assert.AreEqual(1, babySitter.GetStartTime());
        }

        public void BabySitterWhenCalledBedTimeReturnInt()
        {
            BabySitter babySitter = new BabySitter();
            Assert.AreEqual(2, babySitter.GetStartTime());
        }

        public void BabySitterWhenCalledEndTimeReturnInt()
        {
            BabySitter babySitter = new BabySitter();
            Assert.AreEqual(3, babySitter.GetEndTime());
        }
    }
}

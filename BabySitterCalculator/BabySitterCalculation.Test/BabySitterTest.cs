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
           babySitter = new BabySitter(18);
        }

        [TestMethod]
        public void BabySitterCalculatorWhenCalledReturnInt()
        {
            Assert.AreEqual(0, babySitter.Calculate());
        }

        [TestMethod]
        public void BabySitterWhencCalledStartTimeReturnInt()
        {
            Assert.AreEqual(18, babySitter.GetStartTime());
        }

        [TestMethod]
        public void BabySitterWhenCalledBedTimeReturnInt()
        {
            Assert.AreEqual(2, babySitter.GetBedTime());
        }

        [TestMethod]
        public void BabySitterWhenCalledEndTimeReturnInt()
        {
            Assert.AreEqual(3, babySitter.GetEndTime());
        }

        [TestMethod]
        public void BabySitterWhenCalledReturnsValidStartTimeInto24HoursFomrat()
        {
            BabySitter babySitter = new BabySitter(5);
            Assert.AreEqual(5, babySitter.GetStartTime());
        }      
    }
}

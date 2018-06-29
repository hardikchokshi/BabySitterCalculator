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
           babySitter = new BabySitter(18,23,21);
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
            Assert.AreEqual(21, babySitter.GetBedTime());
        }

        [TestMethod]
        public void BabySitterWhenCalledEndTimeReturnInt()
        {
            Assert.AreEqual(23, babySitter.GetEndTime());
        }

        [TestMethod]
        public void BabySitterWhenCalledReturnsValidTimeInto24HoursFomrat()
        {
            BabySitter babySitter = new BabySitter(18,26,21);
            Assert.AreEqual(18, babySitter.GetStartTime());
            Assert.AreEqual(26, babySitter.GetEndTime());
            Assert.AreEqual(21, babySitter.GetBedTime());
        }   

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BabySitterInvalidStartTimeReturnArgumentOutOfRangeException()
        {
            BabySitter babySitter = new BabySitter(6, 23, 21);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BabySitterInvalidEndTimeReturnsArgumentOutOfRangeException()
        {
            BabySitter babySitter = new BabySitter(18, 8, 21);
        }
    }
}

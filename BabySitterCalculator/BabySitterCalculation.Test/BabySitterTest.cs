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
        public void BabySitterPaymentCalculatorWhenCalledReturnInt()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void BabySitterGetStartTimeReturnInt()
        {
            Assert.AreEqual(18, babySitter.GetStartTime());
        }

        [TestMethod]
        public void BabySitterGetBedTimeReturnInt()
        {
            Assert.AreEqual(21, babySitter.GetBedTime());
        }

        [TestMethod]
        public void BabySitteGetBedTimeReturnInt()
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

        [TestMethod]
        public void BabySitterPaymentCalculatorForThreeHoursFromValidStartTime()
        {
            BabySitter babySitter = new BabySitter(17, 20, 21);
            Assert.AreEqual(36, babySitter.PaymentCalculator());
        }

        [TestMethod]
        public void BabySitterPaymentCalculatorFromStartTimeToDefualtBedTime()
        {
            BabySitter babySitter = new BabySitter(17, 21, 21);
            Assert.AreEqual(48, babySitter.PaymentCalculator());
        }

        [TestMethod]
        public void BabySitterPaymentCalculatorFromStartTimeToMidNight()
        {
            BabySitter babySitter = new BabySitter(17, 24, 21);
            Assert.AreNotEqual(48, babySitter.PaymentCalculator());
        }

        
    }
}

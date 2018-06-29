using System;
using BabySitterCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BabySitterCalculation.Test
{
    [TestClass]
    public class BabySitterTest
    {
        [TestMethod]
        public void BabySitterCalculatorWhenCalledReturnInt()
        {
            BabySitter babySitter = new BabySitter();
            Assert.AreEqual(1, babySitter.Calculate());
        }
    }
}

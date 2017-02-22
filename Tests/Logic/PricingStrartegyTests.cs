﻿using System;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Logic
{
    [TestClass]
    public class PricingStrartegyTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.AreEqual(4, Enum.GetNames(typeof(PricingStrategy)).Length);
        }

        [TestMethod]
        public void NotKnownTest()
        {
            Assert.AreEqual(0, (int)PricingStrategy.NotKnown);
        }

        [TestMethod]
        public void AggregatedTest()
        {
            Assert.AreEqual(1, (int) PricingStrategy.Aggregated);
        }

        [TestMethod]
        public void AssignedTest()
        {
            Assert.AreEqual(2, (int) PricingStrategy.Assigned);
        }

        [TestMethod]
        public void NotApplicableTest()
        {
            Assert.AreEqual(9, (int)PricingStrategy.NotApplicable);
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Logic
{
    [TestClass]
    public class PackageTypeTests
    {  

        [TestMethod]
        public void PackageTypeTest()
        {
            PackageType packageType = new PackageType(PricingStrategy.Aggregated);

            string expected = "Aggregated";
            string actual = packageType.PricingStrategy.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}

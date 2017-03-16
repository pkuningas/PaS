using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Tests.Logic
{
    public class ProductTypeTests
    {
        private ProductType productType;

        [TestInitialize]
        public void InitializeTest()
        {
           // productType = new ProductType(); sulgudesse vaja koodi lisada

        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void ConstructorTest()
        {
            string ID = "Name";
            ProductType target = new ProductType(ID);
            Assert.AreEqual<string>(ID, target.ID, "Name");
        }
    }
}
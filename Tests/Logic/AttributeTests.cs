using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Tests.Logic
{
    [TestClass]
    public class AttributeTests
    {
        [TestInitialize]
        public void InitializeTest()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [TestMethod]
        public void ConstructorTest()
        {
            string Category = "Gadgets";
            string ConfirmedBy = "Yes";
            double Value = 500;
            Attribute target = new Attribute(Category, ConfirmedBy, Value);
            Assert.AreEqual<string>(Category, Attribute.Category, "Gadgets");
            //kommentaar

        }
    }
}

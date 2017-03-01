using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Tests.Logic
{
    [TestClass]
    public class ArchetypesTests
    {
        private Archetypes<string> list;
        [TestInitialize]
        public void InitializeTest()
        {
            list = new Archetypes<string>();
            list.Add("A");
            list.Add("B");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            list = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void CountTest()
        {
            var c = list.Count;
            list.Add("C");
            Assert.AreEqual(c + 1, list.Count);
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.IsFalse(list.Contains("C"));
            list.Add("C");
            Assert.IsTrue(list.Contains("C"));
        }

        [TestMethod]
        public void ContainsTest()
        {
            AddTest();
        }
    }
}

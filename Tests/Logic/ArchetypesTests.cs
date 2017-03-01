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
            list.Add("C");
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.IsFalse(list.Contains("C"));
            list.Add("C");
            Assert.IsTrue(list.Contains("C"));
        }

        [TestMethod]
        public void IndexOfTest()
        {
            list.Add("A");
            list.Add("B");
            list.Add("C");
            Assert.AreEqual(0, list.IndexOf("A"));
            Assert.AreEqual(1, list.IndexOf("B"));
            Assert.AreEqual(2, list.IndexOf("C")); 
        }

        [TestMethod]
        public void IndexOfNotInListTest()
        {
            Assert.AreEqual(-1, list.IndexOf("A"));
        }

        [TestMethod]
        public void IndexOfNullTest()
        {
            Assert.AreEqual(-1, list.IndexOf(null));
        }

        [TestMethod]
        public void InsertTest()
        {
            list.Insert(0, "A");
            list.Insert(0, "B");
            list.Insert(1, null);
            Assert.AreEqual(2, list.IndexOf("A"));
            Assert.AreEqual(0, list.IndexOf("B"));
            Assert.AreEqual(1, list.IndexOf(null));
        }
    }
}

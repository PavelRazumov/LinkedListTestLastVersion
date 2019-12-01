using ListApp.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace LinkedListTest
{
    [TestClass]
    public class ListTest
    {
        private LinkedList<int> linkedList;

        [TestInitialize]
        public void SetUp()
        {
            linkedList = new LinkedList<int>();
        }

        [TestMethod]
        public void AddTest()
        {
            linkedList.Add(5);
            Assert.AreEqual(1, linkedList.Count);
        }

        [TestMethod]
        public void AddAndRemoveTest()
        {
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(5);

            linkedList.Remove(3);

            Assert.AreEqual(2, linkedList.Count);
        }

        [TestMethod]
        public void RemoveByIndexTest()
        {
            linkedList.Add(12);
            linkedList.Add(23);

            linkedList.RemoveAt(0);

            Assert.AreEqual(1, linkedList.Count);
        }

        [TestMethod]
        public void InsertByBorderConditions()
        {
            linkedList.Insert(0, 1);
            linkedList.Insert(1, linkedList.Count);
            linkedList.Insert(2, linkedList.Count - 1);

            Assert.AreEqual(3, linkedList.Count);
        }

        [TestMethod]
        public void RemoveByBorderConditions()
        {
            linkedList.RemoveAt(0);

            linkedList.Insert(2, 0);
            linkedList.Insert(3, 1);

            linkedList.RemoveAt(0);

            Assert.AreEqual(1, linkedList.Count);

            linkedList.RemoveAt(0);
            
            Assert.AreEqual(0, linkedList.Count);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace LinearDataStructuresTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void OnInitialCreateListIsEmpty()
        {
            List<int> list = new LinearDataStructures.List<int>();

            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod]
        public void DataIsAddedCorrectlyAndSupportsIndexing()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Assert.IsTrue(list.Count == 3);
            Assert.IsTrue(list[0] == 1);
            Assert.IsTrue(list[1] == 2);
            Assert.IsTrue(list[2] == 3);
        }

        [TestMethod]
        public void CanAddAtSpecifiedIndex()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.AddAt(0, 100);

            Assert.IsTrue(list.Count == 2);
            Assert.IsTrue(list[0] == 100);
            Assert.IsTrue(list[1] == 1);
        }

        [TestMethod]
        public void OnClearListIsEmpty()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);

            Assert.IsTrue(list.Count == 1);
            Assert.IsTrue(list[0] == 1);

            list.Clear();

            // Default value of int.
            Assert.IsTrue(list[0] == 0);
        }

        [TestMethod]
        public void CanVerifyIfListContainsElement()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(11);
            list.Add(111);

            Assert.IsTrue(list.Contains(11));
            Assert.IsFalse(list.Contains(2345));
        }

        [TestMethod]
        public void CanFindIndexOfElements()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);

            int foundIndex = list.IndexOf(1);
            int notFoundIndex = list.IndexOf(500);

            Assert.AreEqual(0, foundIndex);
            Assert.AreEqual(-1, notFoundIndex);
        }

        [TestMethod]
        public void CanRemoveElements()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(6);
            list.Remove(5);

            Assert.IsFalse(list.Contains(5));
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(6, list[1]);
        }

        [TestMethod]
        public void CanRemoveElementsAtIndex()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(6);
            list.RemoveAt(1);

            Assert.IsFalse(list.Contains(5));
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(6, list[1]);
        }

        [TestMethod]
        public void ListCanBeMadeToArray()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(6);

            int[] toArray = list.ToArray();

            Assert.IsInstanceOfType(toArray, typeof(int[]));
        }

        [TestMethod]
        public void ToStringReturnsStringWithAllItems()
        {
            List<int> list = new LinearDataStructures.List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(6);

            string result = list.ToString();
            string expected = "1 5 6";

            Assert.AreEqual(expected, result);
        }
    }
}
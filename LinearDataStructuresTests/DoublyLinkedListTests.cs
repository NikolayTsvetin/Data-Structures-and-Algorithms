using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace LinearDataStructuresTests
{

    [TestClass]
    public class DoublyLinkedListTests
    {
        [TestMethod]
        public void OnInitialCreateLinkedListIsEmpty()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

            Assert.IsNull(doublyLinkedList.First);
            Assert.IsNull(doublyLinkedList.Last);
        }

        [TestMethod]
        public void CanCreateWithValue()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);

            Assert.AreEqual(5, doublyLinkedList.First.Value);
            Assert.AreEqual(5, doublyLinkedList.Last.Value);
        }

        [TestMethod]
        public void CanClearLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);

            Assert.AreEqual(5, doublyLinkedList.First.Value);
            Assert.AreEqual(5, doublyLinkedList.Last.Value);

            doublyLinkedList.Clear();
            Assert.IsNull(doublyLinkedList.First);
            Assert.IsNull(doublyLinkedList.Last);
        }

        [TestMethod]
        public void CanVerifyIfElementExistsInStackOrNot()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);

            bool notExisting = doublyLinkedList.Contains(7);
            bool existing = doublyLinkedList.Contains(5);

            Assert.IsTrue(existing);
            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void CanAddData()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);

            bool existing = doublyLinkedList.Contains(5);
            bool existing2 = doublyLinkedList.Contains(7);

            Assert.IsTrue(existing);
            Assert.IsTrue(existing2);
            Assert.AreEqual(2, doublyLinkedList.Count);
        }

        [TestMethod]
        public void CanAddFirst()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddFirst(7);

            Assert.AreEqual(7, doublyLinkedList.First.Value);
        }

        [TestMethod]
        public void CanAddLast()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);

            Assert.AreEqual(7, doublyLinkedList.Last.Value);
        }

        [TestMethod]
        public void CanAddAfterSpecificElement()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.AddLast(13);

            Assert.AreEqual(5, doublyLinkedList.First.Value);

            doublyLinkedList.AddAfter(7, 100);
            string expectedOutput = "5 7 100 13";
            string output = doublyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void CanFindItemsInLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.AddLast(77);
            doublyLinkedList.AddLast(23);

            DoublyLinkedListNode<int> foundNode = doublyLinkedList.Find(77);

            Assert.IsNotNull(foundNode);
            Assert.AreEqual(77, foundNode.Value);
        }

        [TestMethod]
        public void CanRemoveItemsFromLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.AddLast(8);
            doublyLinkedList.AddLast(9);

            bool existing = doublyLinkedList.Contains(8);

            Assert.IsTrue(existing);

            doublyLinkedList.Remove(8);
            bool notExisting = doublyLinkedList.Contains(8);

            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void CanRemoveFirstItemInLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.AddLast(8);
            doublyLinkedList.AddLast(9);

            Assert.AreEqual(5, doublyLinkedList.First.Value);

            doublyLinkedList.RemoveFirst();

            Assert.AreEqual(7, doublyLinkedList.First.Value);
        }

        [TestMethod]
        public void CanRemoveLastItemInLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(5);
            doublyLinkedList.AddLast(7);
            doublyLinkedList.AddLast(13);

            string expectedOutput = "5 7 13";
            string output = doublyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);

            doublyLinkedList.RemoveLast();
            expectedOutput = "5 7";
            output = doublyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);
        }
    }
}

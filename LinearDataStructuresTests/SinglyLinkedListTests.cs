using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace LinearDataStructuresTests
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        [TestMethod]
        public void OnInitialCreateLinkedListIsEmpty()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            Assert.IsNull(singlyLinkedList.First);
        }

        [TestMethod]
        public void CanCreateWithValue()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);

            Assert.AreEqual(5, singlyLinkedList.First.Value);
        }

        [TestMethod]
        public void CanClearLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);

            Assert.AreEqual(5, singlyLinkedList.First.Value);

            singlyLinkedList.Clear();
            Assert.IsNull(singlyLinkedList.First);
        }

        [TestMethod]
        public void CanVerifyIfElementExistsInStackOrNot()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);

            bool notExisting = singlyLinkedList.Contains(7);
            bool existing = singlyLinkedList.Contains(5);

            Assert.IsTrue(existing);
            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void CanAddData()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);

            bool existing = singlyLinkedList.Contains(5);
            bool existing2 = singlyLinkedList.Contains(7);

            Assert.IsTrue(existing);
            Assert.IsTrue(existing2);
            Assert.AreEqual(2, singlyLinkedList.Count);
        }

        [TestMethod]
        public void CanAddFirst()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddFirst(7);

            Assert.AreEqual(7, singlyLinkedList.First.Value);
        }

        [TestMethod]
        public void CanAddAfterSpecificElement()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);
            singlyLinkedList.AddLast(13);

            Assert.AreEqual(5, singlyLinkedList.First.Value);

            singlyLinkedList.AddAfter(7, 100);
            string expectedOutput = "5 7 100 13";
            string output = singlyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void CanFindItemsInLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);
            singlyLinkedList.AddLast(77);
            singlyLinkedList.AddLast(23);

            SinglyLinkedListNode<int> foundNode = singlyLinkedList.Find(77);

            Assert.IsNotNull(foundNode);
            Assert.AreEqual(77, foundNode.Value);
        }

        [TestMethod]
        public void CanRemoveItemsFromLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);
            singlyLinkedList.AddLast(8);
            singlyLinkedList.AddLast(9);

            bool existing = singlyLinkedList.Contains(8);

            Assert.IsTrue(existing);

            singlyLinkedList.Remove(8);
            bool notExisting = singlyLinkedList.Contains(8);

            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void CanRemoveFirstItemInLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);
            singlyLinkedList.AddLast(8);
            singlyLinkedList.AddLast(9);

            Assert.AreEqual(5, singlyLinkedList.First.Value);

            singlyLinkedList.RemoveFirst();

            Assert.AreEqual(7, singlyLinkedList.First.Value);
        }

        [TestMethod]
        public void CanRemoveLastItemInLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>(5);
            singlyLinkedList.AddLast(7);
            singlyLinkedList.AddLast(13);

            string expectedOutput = "5 7 13";
            string output = singlyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);

            singlyLinkedList.RemoveLast();
            expectedOutput = "5 7";
            output = singlyLinkedList.ToString().Trim();

            Assert.AreEqual(expectedOutput, output);
        }
    }
}

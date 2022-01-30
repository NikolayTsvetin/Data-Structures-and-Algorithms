using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace LinearDataStructuresTests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void OnInitialCreateQueueIsEmpty()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();

            Assert.IsTrue(queue.Count == 0);
        }

        [TestMethod]
        public void CanAddData()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(7);

            Assert.IsTrue(queue.Count == 1);
            Assert.AreEqual(7, queue.Peek());
        }

        [TestMethod]
        public void CanRemoveData()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(77);
            
            Assert.IsTrue(queue.Count == 2);

            queue.Dequeue();

            Assert.IsTrue(queue.Count == 1);
        }

        [TestMethod]
        public void CanClearQueue()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(77);

            Assert.IsTrue(queue.Count == 2);

            queue.Clear();

            // Default value of int
            Assert.IsTrue(queue.Peek() == 0);
        }

        [TestMethod]
        public void CanVerifyIfElementExistsInQueueOrNot()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(77);

            bool existing = queue.Contains(7);
            bool notExisting = queue.Contains(5);

            Assert.IsTrue(existing);
            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void QueueCanBeMadeToArray()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(6);

            int[] toArray = queue.ToArray();

            Assert.IsInstanceOfType(toArray, typeof(int[]));
        }

        [TestMethod]
        public void ToStringReturnsStringWithAllItems()
        {
            Queue<int> queue = new LinearDataStructures.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(6);

            string result = queue.ToString();
            string expected = "1 5 6";

            Assert.AreEqual(expected, result);
        }
    }
}

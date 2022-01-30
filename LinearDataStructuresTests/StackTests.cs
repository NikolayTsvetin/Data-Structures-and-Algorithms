using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace LinearDataStructuresTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void OnInitialCreateStackIsEmpty()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();

            Assert.IsTrue(stack.Count == 0);
        }

        [TestMethod]
        public void CanAddData()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(7);

            Assert.IsTrue(stack.Count == 1);
            Assert.AreEqual(7, stack.Peek());
        }

        [TestMethod]
        public void CanRemoveData()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(7);
            stack.Push(77);

            Assert.IsTrue(stack.Count == 2);

            stack.Pop();

            Assert.IsTrue(stack.Count == 1);
        }

        [TestMethod]
        public void CanClearStack()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(7);
            stack.Push(77);

            Assert.IsTrue(stack.Count == 2);

            stack.Clear();

            // Default value of int
            Assert.IsTrue(stack.Peek() == 0);
        }

        [TestMethod]
        public void CanVerifyIfElementExistsInStackOrNot()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(7);
            stack.Push(77);

            bool existing = stack.Contains(7);
            bool notExisting = stack.Contains(5);

            Assert.IsTrue(existing);
            Assert.IsFalse(notExisting);
        }

        [TestMethod]
        public void StackCanBeMadeToArray()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(6);

            int[] toArray = stack.ToArray();

            Assert.IsInstanceOfType(toArray, typeof(int[]));
        }

        [TestMethod]
        public void ToStringReturnsStringWithAllItems()
        {
            Stack<int> stack = new LinearDataStructures.Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(6);

            string result = stack.ToString();
            string expected = "1 5 6";

            Assert.AreEqual(expected, result);
        }
    }
}

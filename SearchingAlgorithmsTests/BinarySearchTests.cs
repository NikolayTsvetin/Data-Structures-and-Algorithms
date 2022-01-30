using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchingAlgorithms;

namespace SearchingAlgorithmsTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void AssertCorrectSearchingRecursive()
        {
            int[] array = new int[] { 1, 2, 3, 12, 54, 600 };
            int expectedResult = 5;

            int result = BinarySearchClass.BinarySearchRecursive(array, 600);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AssertCorrectSearchingIterative()
        {
            int[] array = new int[] { 1, 2, 3, 12, 54, 600 };
            int expectedResult = 5;

            int result = BinarySearchClass.BinarySearchIterative(array, 600);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AssertResultIfItemIsNotFoundRecursive()
        {
            int[] array = new int[] { 1, 2, 3, 12, 54, 600 };
            int expectedResult = -1;

            int result = BinarySearchClass.BinarySearchRecursive(array, 123);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AssertResultIfItemIsNotFoundIterative()
        {
            int[] array = new int[] { 1, 2, 3, 12, 54, 600 };
            int expectedResult = -1;

            int result = BinarySearchClass.BinarySearchIterative(array, 123);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
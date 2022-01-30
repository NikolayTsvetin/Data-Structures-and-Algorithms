using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;
using System.Linq;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void AssertCorrectSorting()
        {
            int[] arrayToSort = new int[] { 1, 2, 3, 0, 42, 12, 85, -54 };
            int[] expectedResult = new int[] { -54, 0, 1, 2, 3, 12, 42, 85 };
            BubbleSortClass.BubbleSort<int>(arrayToSort);

            bool areEqual = Enumerable.SequenceEqual(expectedResult, arrayToSort);
            Assert.AreEqual(true, areEqual);
        }
    }
}
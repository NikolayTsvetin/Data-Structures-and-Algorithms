using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void AssertCorrectSorting()
        {
            int[] arrayToSort = new int[] { 13, -5, 65, 0, 12 };
            int[] expectedResult = new int[] { -5, 0, 12, 13, 65 };
            int[] result = arrayToSort.MergeSort();

            bool areEqual = Enumerable.SequenceEqual(expectedResult, result);
            Assert.AreEqual(true, areEqual);
        }
    }
}

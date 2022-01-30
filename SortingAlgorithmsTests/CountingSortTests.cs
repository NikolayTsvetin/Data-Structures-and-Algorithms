using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SortingAlgorithms;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class CountingSortTests
    {
        [TestMethod]
        public void AssertCorrectSorting()
        {
            int[] arrayToSort = new int[] { 12, 55, 55, 0, 12, 55 };
            int[] expectedResult = new int[] { 0, 12, 12, 55, 55, 55 };
            int[] result = arrayToSort.CountingSort();

            bool areEqual = Enumerable.SequenceEqual(expectedResult, result);
            Assert.AreEqual(true, areEqual);
        }
    }
}

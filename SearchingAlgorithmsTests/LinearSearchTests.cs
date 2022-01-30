using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchingAlgorithms;

namespace SearchingAlgorithmsTests
{
    [TestClass]
    public class LinearSearchTests
    {
        [TestMethod]
        public void AssertCorrectSearching()
        {
            int[] array = new int[] { 123, 500, -33, 1, 2, 3, 12, 54, 600 };
            int expectedResult = 2;

            int result = LinearSeachClass.FindFirst(array, -33);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AssertResultIfItemIsNotFound()
        {
            int[] array = new int[] { 1, 2, 3, 12, 54, 600 };
            int expectedResult = -1;

            int result = LinearSeachClass.FindFirst(array, 123);

            Assert.AreEqual(expectedResult, result);
        }
    }
}

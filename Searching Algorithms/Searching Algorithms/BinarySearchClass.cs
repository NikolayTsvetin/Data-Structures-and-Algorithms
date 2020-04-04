using System;

namespace Searching_Algorithms
{
    public static class BinarySearchClass
    {
        public static int BinarySearchRecursive<T>(this T[] array, T element)
            where T : IComparable<T>
        {
            int result = BinarySearchInRange(array, 0, array.Length, element);

            return result;
        }

        private static int BinarySearchInRange<T>(T[] array, int left, int right, T element)
            where T : IComparable<T>
        {
            if (left >= right)
            {
                return -1;
            }

            int middleIndex = (left + right) / 2;
            T middleElement = array[middleIndex];

            if (middleElement.CompareTo(element) < 0)
            {
                return BinarySearchInRange(array, middleIndex + 1, array.Length, element);

            }
            else if (middleElement.CompareTo(element) > 0)
            {
                return BinarySearchInRange(array, 0, middleIndex, element);
            }

            return middleIndex;
        }

        public static int BinarySearchIterative<T>(this T[] array, T element)
            where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length;

            while (left < right)
            {
                int middleIndex = (left + right) / 2;

                if (array[middleIndex].CompareTo(element) < 0)
                {
                    left = middleIndex + 1;
                }
                else if (array[middleIndex].CompareTo(element) > 0)
                {
                    right = middleIndex;
                }
                else
                {
                    return middleIndex;
                }
            }

            return -1;
        }
    }
}

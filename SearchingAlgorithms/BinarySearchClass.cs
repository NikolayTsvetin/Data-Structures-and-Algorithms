namespace SearchingAlgorithms
{
    public static class BinarySearchClass
    {
        public static int BinarySearchRecursive<T>(this T[] array, T element)
            where T : IComparable<T>
        {
            return BinarySearchInRange(array, 0, array.Length - 1, element);
        }

        private static int BinarySearchInRange<T>(T[] array, int left, int right, T element)
            where T : IComparable<T>
        {
            if (right >= left)
            {
                int middleIndex = left + (right - left) / 2;
                T middleElement = array[middleIndex];

                if (middleElement.CompareTo(element) == 0)
                {
                    return middleIndex;
                }

                if (middleElement.CompareTo(element) < 0)
                {
                    return BinarySearchInRange(array, middleIndex + 1, array.Length - 1, element);

                }
                else if (middleElement.CompareTo(element) > 0)
                {
                    return BinarySearchInRange(array, 0, middleIndex - 1, element);
                }

                return middleIndex;
            }

            return -1;
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
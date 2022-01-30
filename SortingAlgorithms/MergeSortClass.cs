namespace SortingAlgorithms
{
    public static class MergeSortClass
    {
        public static T[] MergeSort<T>(this T[] array)
            where T : IComparable<T>
        {
            if (array.Length < 2)
            {
                return array;
            }

            int middle = array.Length / 2;
            List<T> leftHalf = new List<T>();
            List<T> rightHalf = new List<T>();

            for (int i = 0; i < middle; i++)
            {
                leftHalf.Add(array[i]);
            }

            for (int i = middle; i < array.Length; i++)
            {
                rightHalf.Add(array[i]);
            }

            T[] sortedLeftHalf = leftHalf.ToArray().MergeSort();
            T[] sortedRightHalf = rightHalf.ToArray().MergeSort();

            T[] result = Merge(sortedLeftHalf, sortedRightHalf);

            return result;
        }

        private static T[] Merge<T>(T[] leftHalf, T[] rightHalf)
            where T : IComparable<T>
        {
            T[] result = new T[leftHalf.Length + rightHalf.Length];
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < leftHalf.Length && rightIndex < rightHalf.Length)
            {
                T leftNumber = leftHalf[leftIndex];
                T rightNumber = rightHalf[rightIndex];

                if (leftNumber.CompareTo(rightNumber) < 0)
                {
                    result[leftIndex + rightIndex] = leftNumber;
                    leftIndex++;
                }
                else
                {
                    result[leftIndex + rightIndex] = rightNumber;
                    rightIndex++;
                }
            }

            while (leftIndex < leftHalf.Length)
            {
                T leftNumber = leftHalf[leftIndex];
                result[leftIndex + rightIndex] = leftNumber;
                leftIndex++;
            }

            while (rightIndex < rightHalf.Length)
            {
                T rightNumber = rightHalf[rightIndex];
                result[leftIndex + rightIndex] = rightNumber;
                rightIndex++;
            }

            return result;
        }
    }
}

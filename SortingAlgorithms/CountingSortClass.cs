namespace SortingAlgorithms
{
    public static class CountingSortClass
    {
        public static int[] CountingSort(this int[] array)
        //where T : IComparable<T>
        {
            int maxNumberInArray = array.Max();
            int[] count = new int[maxNumberInArray + 1];
            int[] sorted = new int[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                int currentNumber = count[i];

                if (currentNumber > 0)
                {
                    for (int j = 0; j < currentNumber; j++)
                    {
                        sorted[index] = i;
                        index++;
                    }
                }
            }

            return sorted;
        }
    }
}

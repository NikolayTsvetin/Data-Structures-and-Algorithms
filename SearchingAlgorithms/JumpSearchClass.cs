namespace SearchingAlgorithms
{
    public static class JumpSearchClass
    {
        public static int JumpSearch<T>(this T[] array, T element)
            where T : IComparable<T>
        {
            int chunkSize = 3;
            int lowerBound = 0;
            int upperBound = -1;

            while (upperBound < 0)
            {
                if (array[chunkSize].CompareTo(element) < 0)
                {
                    // go to next chunk
                    lowerBound = chunkSize;
                    chunkSize *= 2;

                    if (chunkSize > array.Length -1)
                    {
                        chunkSize = array.Length - 1;
                        upperBound = chunkSize;
                        lowerBound = upperBound / 2;
                    }
                }
                else
                {
                    upperBound = chunkSize + 1;
                }
            }

            for (int i = lowerBound; i < upperBound; i++)
            {
                if (array[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

namespace SearchingAlgorithms
{
    public static class LinearSeachClass
    {
        public static int FindFirst<T>(this IEnumerable<T> collection, T value)
            where T : IComparable<T>
        {
            int index = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(value) == 0)
                {
                    return index;
                }

                index++;
            }

            return -1;
        }

        public static int FindFirst<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            int index = 0;

            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }
    }
}

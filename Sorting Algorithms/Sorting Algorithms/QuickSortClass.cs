using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class QuickSortClass
    {
        public static T[] QuickSort<T>(this T[] array)
            where T : IComparable<T>
        {
            if (array.Length < 2)
            {
                return array;
            }

            T pivot = array[0];
            List<T> leftPart = new List<T>();
            List<T> rightPart = new List<T>();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(pivot) < 0)
                {
                    leftPart.Add(array[i]);
                }
                else
                {
                    rightPart.Add(array[i]);
                }
            }

            T[] sortedLeftPart = leftPart.ToArray().QuickSort();
            T[] sortedRightPart = rightPart.ToArray().QuickSort();

            T[] result = new T[array.Length];

            for (int i = 0; i < sortedLeftPart.Length; i++)
            {
                result[i] = sortedLeftPart[i];
            }

            result[sortedLeftPart.Length] = pivot;

            for (int i = 0; i < sortedRightPart.Length; i++)
            {
                result[sortedLeftPart.Length + i + 1] = sortedRightPart[i];
            }

            return result;
        }
    }
}

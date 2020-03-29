using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class InsertionSortClass
    {
        public static void InsertionSort<T>(this T[] array)
            where T : IComparable<T>
        {
            int j = 0;
            int iHelper = 0;

            for (int i = 1; i < array.Length; i++)
            {
                T currentElement = array[i];
                j = i;
                iHelper = i;

                while (j > 0)
                {
                    j--;

                    if (array[j].CompareTo(currentElement) > 0)
                    {
                        T temp = array[j];
                        array[j] = currentElement;
                        array[iHelper] = temp;
                        iHelper--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}

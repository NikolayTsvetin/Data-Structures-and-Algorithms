using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class CountingSortClass
    {
        public static int[] CountingSort(this int[] array)
            //where T : IComparable<T>
        {
            int maxNumberInArray = array.Max();
            int[] count = new int[maxNumberInArray];
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

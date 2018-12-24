using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedNumbers = new List<int>() { 14, 13, 56, 123, 52, 6, 12, 0 };

            Console.WriteLine(string.Join(", ", unsortedNumbers));

            Quicksort(unsortedNumbers, 0, unsortedNumbers.Count - 1);

            Console.WriteLine(string.Join(", ", unsortedNumbers));
        }

        private static void Quicksort(List<int> unsortedNumbers, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int partitioningIndex = Partition(unsortedNumbers, startIndex, endIndex);

                Quicksort(unsortedNumbers, startIndex, partitioningIndex - 1);
                Quicksort(unsortedNumbers, partitioningIndex, endIndex);
            }
        }

        private static int Partition(List<int> unsortedNumbers, int startIndex, int endIndex)
        {
            int pivot = unsortedNumbers[endIndex];
            int i = startIndex - 1;

            for (int j = startIndex; j < endIndex; j++)
            {
                if (unsortedNumbers[j] <= pivot)
                {
                    i++;

                    int temp1 = unsortedNumbers[i];
                    unsortedNumbers[i] = unsortedNumbers[j];
                    unsortedNumbers[j] = temp1;
                }
            }

            int temp = unsortedNumbers[i + 1];
            unsortedNumbers[i + 1] = unsortedNumbers[endIndex];
            unsortedNumbers[endIndex] = temp;

            return i + 1;
        }
    }
}

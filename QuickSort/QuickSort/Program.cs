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

            List<int> sortedNumbers = Quicksort(unsortedNumbers, 0, unsortedNumbers.Count - 1);

            Console.WriteLine(string.Join(", ", sortedNumbers));
        }

        private static List<int> Quicksort(List<int> unsortedNumbers, int startIndex, int endIndex)
        {
            int pivot = unsortedNumbers[0];
            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();

            for (int i = 1; i < unsortedNumbers.Count; i++)
            {
                if (unsortedNumbers[i] < pivot)
                {
                    smaller.Add(unsortedNumbers[i]);
                }
                else
                {
                    bigger.Add(unsortedNumbers[i]);
                }
            }

            smaller.Add(pivot);

            var result = smaller.Concat(bigger).ToList();

            return result;
        }
    }
}

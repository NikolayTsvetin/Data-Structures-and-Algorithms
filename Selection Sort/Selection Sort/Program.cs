using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedNumbers = new List<int>() { 10, 12, 3, 0, 8, 6, 1, 1, 4 };

            SelectionSort(unsortedNumbers);
        }

        private static void SelectionSort(List<int> unsortedNumbers)
        {
            List<int> sortedNumber = new List<int>();

            for (int i = 0; i < unsortedNumbers.Count; i++)
            {
                int minimumElement = unsortedNumbers[i];
                int minimumElementIndex = i;
                int newIndex = i;

                for (int j = i + 1; j < unsortedNumbers.Count; j++)
                {
                    if (unsortedNumbers[j] < minimumElement)
                    {
                        minimumElement = unsortedNumbers[j];
                        newIndex = j;
                    }
                }

                if (minimumElementIndex != newIndex)
                {
                    var temp = unsortedNumbers[minimumElementIndex];
                    unsortedNumbers[minimumElementIndex] = minimumElement;
                    unsortedNumbers[newIndex] = temp;
                }
            }

            Console.WriteLine(String.Join(", ", unsortedNumbers));
        }
    }
}

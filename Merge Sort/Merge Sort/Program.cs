using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedNumbers = new List<int>() { 3, 12, 9, 0, 2, 8, 3, 3, 6 };

            Console.WriteLine($"Unsorted numbers are: {string.Join(", ", unsortedNumbers)}");

            List<int> sorted = MergeSort(unsortedNumbers);

            Console.WriteLine($"Result after merge sort is: {string.Join(", ", sorted)}");
        }

        private static List<int> MergeSort(List<int> unsortedNumbers)
        {
            if (unsortedNumbers.Count <= 1)
            {
                return unsortedNumbers;
            }

            List<int> leftHalf = new List<int>();
            List<int> rightHalf = new List<int>();
            int half = unsortedNumbers.Count / 2;

            for (int i = 0; i < half; i++)
            {
                leftHalf.Add(unsortedNumbers[i]);
            }

            for (int i = half; i < unsortedNumbers.Count; i++)
            {
                rightHalf.Add(unsortedNumbers[i]);
            }

            Console.WriteLine($"Left half is {string.Join(", ", leftHalf)}");
            Console.WriteLine($"Right half is {string.Join(", ", rightHalf)}");

            leftHalf = MergeSort(leftHalf);
            rightHalf = MergeSort(rightHalf);

            return Merge(leftHalf, rightHalf);
        }

        private static List<int> Merge(List<int> leftHalf, List<int> rightHalf)
        {
            List<int> result = new List<int>();

            while (leftHalf.Count > 0 || rightHalf.Count > 0)
            {
                if (leftHalf.Count > 0 && rightHalf.Count > 0)
                {
                    if (leftHalf.First() <= rightHalf.First())
                    {
                        result.Add(leftHalf.First());
                        leftHalf.Remove(leftHalf.First());
                    }
                    else
                    {
                        result.Add(rightHalf.First());
                        rightHalf.Remove(rightHalf.First());
                    }
                }
                else if (leftHalf.Count > 0)
                {
                    result.Add(leftHalf.First());
                    leftHalf.Remove(leftHalf.First());
                }
                else if (rightHalf.Count > 0)
                {
                    result.Add(rightHalf.First());
                    rightHalf.Remove(rightHalf.First());
                }
            }

            return result;
        }
    }
}

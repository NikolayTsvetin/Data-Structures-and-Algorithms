using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedNumbers = new int[] { 3, 5, 1, 2, 9, 11, 0, 3, 6 };
            Console.WriteLine(String.Join(", ", unsortedNumbers));
            int[] result = unsortedNumbers.MergeSort();
            Console.WriteLine(String.Join(", ", result));
        }
    }
}

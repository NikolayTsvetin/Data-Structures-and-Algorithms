using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            BinarySearch(numbers, 3);
        }

        private static void BinarySearch(List<int> numbers, int searchedNumber)
        {
            int resultRecursive = BinarySeachRecursive(numbers, 0, numbers.Count - 1, searchedNumber);
            int resultIterative = BinarySearchIterative(numbers, searchedNumber);

            Console.WriteLine($"Searching {searchedNumber}. Result in recursive call is {resultRecursive}. Result in iterative is {resultIterative}.");
        }

        private static int BinarySearchIterative(List<int> numbers, int searchedNumber)
        {
            int left = 0;
            int right = numbers.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (searchedNumber == numbers[middle])
                {
                    return middle;
                }
                else if (searchedNumber < numbers[middle])
                {
                    right = middle - 1;
                }
                else if (searchedNumber > numbers[middle])
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

        private static int BinarySeachRecursive(List<int> numbers, int left, int right, int searchedNumber)
        {
            if (left > right)
            {
                return -1;
            }

            int middle = (left + right) / 2;

            if (searchedNumber == numbers[middle])
            {
                return middle;
            }
            else if (searchedNumber < numbers[middle])
            {
                return BinarySeachRecursive(numbers, left, middle - 1, searchedNumber);
            }
            else if (searchedNumber > numbers[middle])
            {
                return BinarySeachRecursive(numbers, middle + 1, numbers.Count - 1, searchedNumber);
            }
            else
            {
                return -1;
            }
        }

    }
}

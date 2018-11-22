using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 2, 3, 6, 1, 3 };
            int[] result = InsertionSort(nums);

            Console.WriteLine(String.Join(", ", result));
        }

        private static int[] InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int currentElement = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > currentElement)
                {
                    nums[j + 1] = nums[j];
                    j -= 1;
                }

                nums[j + 1] = currentElement;
            }

            return nums;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Count_For_Each_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 3, 4, 1, 5, 19, 2, 1, 1, 1 };

            PrintCountForEachElement(nums);
        }

        static void PrintCountForEachElement(int[] nums)
        {
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentElement = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == currentElement)
                    {
                        count++;
                    }
                }

                if (!dict.ContainsKey(currentElement))
                {
                    dict.Add(currentElement, count);
                }

                count = 0;
            }

            foreach (var key in dict.Keys)
            {
                Console.WriteLine($"Number {key} is matched {dict[key]} times.");
            }
        }
    }
}

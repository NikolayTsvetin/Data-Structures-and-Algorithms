using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 9, 1, 1, 1, 9 };

            Console.WriteLine(String.Join(", ", LongestSubsequenceOfEqualNumbers(numbers)));
        }

        static List<int> LongestSubsequenceOfEqualNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            int counter = 0;
            int index = 0;
            int biggestCount = 0;
            int currentElement = 0;
            int startIndex = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                currentElement = list[i];
                counter++;
                index = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] == currentElement)
                    {
                        counter++;

                        if (counter > biggestCount)
                        {
                            biggestCount = counter;
                            startIndex = i;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                counter = 0;
                index = 0;
            }

            Console.WriteLine($"biggest count is {biggestCount} starts at index {startIndex}");

            for (int i = startIndex; i < startIndex + biggestCount; i++)
            {
                result.Add(list[i]);
            }

            return result;
        }
    }
}

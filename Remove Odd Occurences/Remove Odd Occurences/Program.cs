using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 3, 1, 64, 23, 7, 1, 3, 7 };

            RemoveNumbersOccuringOddNumbersOfTimes(numbers);
        }

        static void RemoveNumbersOccuringOddNumbersOfTimes(List<int> list)
        {
            List<int> toRemove = new List<int>();

            foreach (var num in list)
            {
                if (OddOccurences(num, list))
                {
                    if (!toRemove.Contains(num))
                    {
                        toRemove.Add(num);
                    }
                }
            }

            for (int i = 0; i < toRemove.Count; i++)
            {
                list.RemoveAll(x => x == toRemove[i]);
            }

            Console.WriteLine(String.Join(", ", list));
        }

        static bool OddOccurences(int number, List<int> list)
        {
            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    counter++;
                }
            }

            return counter % 2 != 0 ? true : false;
        }
    }
}

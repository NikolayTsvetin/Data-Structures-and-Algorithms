using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 13, 2, 46, 10, 8, 18, 99, 93 };

            Console.WriteLine($"Numbers before sorting are: {string.Join(", ", numbers)}.");

            BubbleSort(numbers);
        }

        public static void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Sorted numbers are: {string.Join(", ", numbers)}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayWithMissingNumbers = new int[] { 1, 2, 11, 22, 1 };
            int[] fullArray = new int[] { 1, 2, 11, 22, 1, 5, 1, 2, 13 };

            var result = MissingNumbers(arrayWithMissingNumbers, fullArray);

            Console.WriteLine(string.Join(", ", result));

        }

        static int[] MissingNumbers(int[] arrayWithMissingNumbers, int[] fullArray)
        {
            List<int> missingNumbers = new List<int>();

            for (int i = 0; i < arrayWithMissingNumbers.Length; i++)
            {
                int currentNumber = arrayWithMissingNumbers[i];

                int countInMissingArray = CountTimesNumberOccurs(currentNumber, arrayWithMissingNumbers);
                int countInFullArray = CountTimesNumberOccurs(currentNumber, fullArray);

                if (countInFullArray > countInMissingArray)
                {
                    if (!missingNumbers.Contains(currentNumber))
                    {
                        missingNumbers.Add(currentNumber);
                    }
                }

            }

            for (int i = 0; i < fullArray.Length; i++)
            {
                int currentNumber = fullArray[i];

                if (Array.IndexOf(arrayWithMissingNumbers, currentNumber) < 0)
                {
                    if (!missingNumbers.Contains(currentNumber))
                    {
                        missingNumbers.Add(currentNumber);
                    }
                }
            }

            missingNumbers.Sort();

            return missingNumbers.ToArray();
        }

        static int CountTimesNumberOccurs(int n, int[] array)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = CalculateOperations(5, 16);
        }

        private static int CalculateOperations(int startNumber, int endNumber)
        {
            int target = endNumber / 2;
            int diff = 0;
            int operations = 0;
            int timesToIncreaseByTwo = 0;

            Console.WriteLine($"Start from {startNumber} and end at {endNumber}");

            if (target > startNumber)
            {
                diff = target - startNumber;


                if (diff % 2 != 0)
                {
                    startNumber++;
                    operations++;

                    timesToIncreaseByTwo = diff / 2;

                    for (int i = 0; i < timesToIncreaseByTwo; i++)
                    {
                        startNumber += 2;
                        operations++;
                    }

                    startNumber *= 2;
                    operations++;
                }
                else
                {
                    timesToIncreaseByTwo = diff / 2;

                    for (int i = 0; i < timesToIncreaseByTwo; i++)
                    {
                        startNumber += 2;
                        operations++;
                    }

                    startNumber *= 2;
                    operations++;
                }
            }
            else if (target == startNumber)
            {
                startNumber *= 2;
                operations++;
            }
            else
            {
                diff = endNumber - startNumber;

                if (diff % 2 != 0)
                {
                    startNumber++;
                    operations++;

                    timesToIncreaseByTwo = diff / 2;

                    for (int i = 0; i < timesToIncreaseByTwo; i++)
                    {
                        startNumber += 2;
                        operations++;
                    }
                }
                else
                {
                    timesToIncreaseByTwo = diff / 2;

                    for (int i = 0; i < timesToIncreaseByTwo; i++)
                    {
                        startNumber += 2;
                        operations++;
                    }
                }
            }

            Console.WriteLine($"Finished at {startNumber} with {operations} operations.");

            return operations;
        }
    }
}

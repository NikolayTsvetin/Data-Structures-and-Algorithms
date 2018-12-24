using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int timesToShift = 3;
            int[] shiftedArray = leftRotate(array, array.Length, timesToShift);

            Console.WriteLine(string.Join(", ", shiftedArray));
        }

        static int[] leftRotate(int[] array, int length, int shift)
        {
            int[] copy = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                int currentEl = array[i];
                int indexToBePlaced = i - shift;

                while (indexToBePlaced < 0)
                {
                    indexToBePlaced = length + indexToBePlaced;
                }

                copy[indexToBePlaced] = currentEl;
            }

            return copy;
        }
    }
}

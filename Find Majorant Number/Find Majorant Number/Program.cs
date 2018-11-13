using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Majorant_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int majorant = FindMajorantNumber(nums);
        }

        static int FindMajorantNumber(int[] nums)
        {
            int key = (nums.Length / 2) + 1;
            int counter = 0;
            int majorant = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentElement = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == currentElement)
                    {
                        counter++;
                    }
                }

                if (counter > majorant)
                {
                    majorant = currentElement;
                }

                counter = 0;
            }

            return majorant;
        }
    }
}

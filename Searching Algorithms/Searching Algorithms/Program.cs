using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 6, 7, 10, 19, 22 };

            Console.WriteLine(numbers.JumpSearch(222));
        }
    }
}

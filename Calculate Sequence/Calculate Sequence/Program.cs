using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSequence(2);
        }

        private static void CalculateSequence(int n)
        {
            Queue<int> queue = new Queue<int>();
            List<int> helper = new List<int>();
            int s1 = n;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int counter = 0;

            queue.Enqueue(s1);

            while (queue.Count < 13)
            {
                s2 = n + 1;
                s3 = 2 * n + 1;
                s4 = n + 2;

                queue.Enqueue(s2);
                queue.Enqueue(s3);
                queue.Enqueue(s4);

                helper.Add(s2);
                helper.Add(s3);
                helper.Add(s4);

                n = helper[counter];

                counter++;
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}

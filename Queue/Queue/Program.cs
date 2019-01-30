using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.ToString());

            queue.Clean();
            Console.WriteLine(queue.ToString());
        }
    }
}

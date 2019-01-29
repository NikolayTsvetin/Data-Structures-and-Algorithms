using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();

            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Peek());

            myStack.Clear();
            Console.WriteLine(myStack.Peek());
        }
    }
}

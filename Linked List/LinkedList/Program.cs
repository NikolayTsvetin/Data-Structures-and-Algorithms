using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                myLinkedList.AddLast(i);
            }

            for (int i = 5; i < 10; i++)
            {
                myLinkedList.AddFirst(i);
            }

            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();

            myLinkedList.PrintAllNodes();
            Console.WriteLine(myLinkedList.GetLength());

            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();
            myLinkedList.PrintAllNodes();
            Console.WriteLine(myLinkedList.GetLength());

            Console.WriteLine("-------- REVERSED ----------");

            myLinkedList = myLinkedList.Reverse();
            myLinkedList.PrintAllNodes();

        }
    }
}

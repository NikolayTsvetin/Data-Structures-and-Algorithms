using System;
using System.Collections.Generic;

namespace Linear_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            for (int i = 0; i < 4; i++)
            {
                doublyLinkedList.AddFirst(i);
            }

            Console.WriteLine(doublyLinkedList.ToString());

            doublyLinkedList.AddLast(100);
            doublyLinkedList.AddAfter(3, 300);
            doublyLinkedList.AddAfter(100, 200);

            Console.WriteLine(doublyLinkedList.ToString());

        }
    }
}

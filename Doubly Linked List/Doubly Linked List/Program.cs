using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList<int> myLinkedList = new DoublyLinkedList<int>();

            for (int i = 0; i < 7; i++)
            {
                myLinkedList.AddLast(i);
            }

            myLinkedList.RemoveFirst();
            myLinkedList.RemoveLast();
            myLinkedList.Print();
            
        }
    }
}

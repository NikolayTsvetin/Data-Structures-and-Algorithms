using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DoublyLinkedList<T>
    {
        private Node<T> head;

        public DoublyLinkedList()
        {
            head = null;
        }

        public void AddFirst(T valueToAdd)
        {
            if (head == null)
            {
                head = new Node<T>(valueToAdd);
            }
            else
            {
                Node<T> oldHead = head;
                head = new Node<T>(valueToAdd);
                head.Next = oldHead;
                oldHead.Prev = head;
            }
        }

        public void AddLast(T valueToAdd)
        {
            if (head == null)
            {
                head = new Node<T>(valueToAdd);
            }
            else
            {
                Node<T> lastElement = head;

                while (lastElement.Next != null)
                {
                    lastElement = lastElement.Next;
                }

                Node<T> newLast = new Node<T>(valueToAdd);
                lastElement.Next = newLast;
                newLast.Prev = lastElement;
            }
        }        

        public void Print()
        {
            StringBuilder result = new StringBuilder();
            Node<T> tempEl = head;

            if (tempEl == null)
            {
                result.Append("The linked list is empty.");
            }
            else
            {
                while (tempEl.Next != null)
                {
                    result.Append($" {tempEl.Value}");
                    tempEl = tempEl.Next;

                    if (tempEl.Next == null)
                    {
                        result.Append($" {tempEl.Value}");
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                if (head.Next != null)
                {
                    head = head.Next;
                    head.Prev = null;
                }
                else
                {
                    head = null;
                }
            }
        }

        public void RemoveLast()
        {
            Node<T> lastElement = head;
            Node<T> beforeLast = head;

            while (lastElement.Next != null)
            {
                beforeLast = lastElement;
                lastElement = lastElement.Next;
            }

            beforeLast.Next = null;
            lastElement.Prev = null;
        }
    }
}

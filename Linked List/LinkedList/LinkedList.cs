using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void AddLast(T newValue)
        {
            if (head == null)
            {
                head = new Node<T>(newValue);
                head.Next = null;
            }
            else
            {
                Node<T> currentElement = head;

                while (currentElement.Next != null)
                {
                    currentElement = currentElement.Next;
                }

                currentElement.Next = new Node<T>(newValue);
            }
        }

        public void AddFirst(T newValue)
        {
            if (head == null)
            {
                head = new Node<T>(newValue);
                head.Next = null;
            }
            else
            {
                Node<T> toAdd = new Node<T>(newValue);
                Node<T> previousHead = head;
                head = toAdd;
                head.Next = previousHead;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                //Node<T> elementToRemove = head;
                //Node<T> newHead = head.Next;

                head = head.Next;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                Node<T> currentELement = head;
                Node<T> previousElement = head;

                while (currentELement.Next != null)
                {
                    previousElement = currentELement;
                    currentELement = currentELement.Next;
                }

                previousElement.Next = null;
            }
        }

        public void PrintAllNodes()
        {
            Node<T> currentElement = head;
            StringBuilder result = new StringBuilder();

            while (currentElement != null)
            {
                result.Append($" {currentElement.Value}");
              //  Console.WriteLine(result.ToString());
                currentElement = currentElement.Next;
            }

            Console.WriteLine(result.ToString().Trim(' '));
        }

        public int GetLength()
        {
            Node<T> currentElement = head;
            int length = 0;

            while (currentElement != null)
            {
                length++;
                currentElement = currentElement.Next;
            }

            return length;
        }

        public T GetFirst()
        {
            if (head != null)
            {
                return head.Value;
            }

            return default(T);
        }
    }
}

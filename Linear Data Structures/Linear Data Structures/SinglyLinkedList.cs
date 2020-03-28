using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    public class SinglyLinkedList<T>
        where T : IComparable<T>
    {
        public SinglyLinkedListNode<T> First;
        public int Count { get; private set; }

        public SinglyLinkedList()
        {
            this.First = null;
        }

        public SinglyLinkedList(T value)
        {
            this.First = new SinglyLinkedListNode<T>(value);
            this.Count = 1;
        }

        public void AddAfter(T elementToAddAfter, T value)
        {
            SinglyLinkedListNode<T> elementToAdd = new SinglyLinkedListNode<T>(value);

            if (this.First != null)
            {
                SinglyLinkedListNode<T> currentElement = this.First;

                if (currentElement.Value.CompareTo(elementToAddAfter) == 0)
                {
                    _InsertAfter(currentElement, elementToAdd);

                    return;
                }

                while (currentElement.Next != null)
                {
                    currentElement = currentElement.Next;

                    if (currentElement.Value.CompareTo(elementToAddAfter) == 0)
                    {
                        _InsertAfter(currentElement, elementToAdd);

                        return;
                    }
                }

                throw new ArgumentException($"There is no such element as: {elementToAddAfter}");

            }
            else
            {
                throw new ArgumentException("Cannot add after in empty linked list.");
            }
        }

        public void AddFirst(T value)
        {
            SinglyLinkedListNode<T> elementToAdd = new SinglyLinkedListNode<T>(value);

            if (this.First != null)
            {
                elementToAdd.Next = this.First;
                this.First = elementToAdd;
            }
            else
            {
                this.First = elementToAdd;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            SinglyLinkedListNode<T> elementToAdd = new SinglyLinkedListNode<T>(value);

            if (this.First != null)
            {
                SinglyLinkedListNode<T> currentElement = this.First;

                while (currentElement.Next != null)
                {
                    currentElement = currentElement.Next;
                }

                currentElement.Next = elementToAdd;
            }
            else
            {
                this.First = elementToAdd;
            }

            this.Count++;
        }

        public void Clear()
        {
            this.First = null;
            this.Count = 0;
        }

        public bool Contains(T value)
        {
            SinglyLinkedListNode<T> currentElement = this.First;

            while (currentElement != null)
            {
                if (currentElement.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentElement = currentElement.Next;
            }

            return false;
        }

        public SinglyLinkedListNode<T> Find(T value)
        {
            if (this.First != null)
            {
                SinglyLinkedListNode<T> currentElement = this.First;

                while (currentElement != null)
                {
                    if (currentElement.Value.CompareTo(value) == 0)
                    {
                        return currentElement;
                    }

                    currentElement = currentElement.Next;
                }

                return null;
            }

            throw new InvalidOperationException("Cannot search in empty linked list.");
        }

        public void Remove(T value)
        {
            if (this.First != null)
            {
                SinglyLinkedListNode<T> currentElement = this.First;
                SinglyLinkedListNode<T> previousElement = this.First;
                SinglyLinkedListNode<T> elementToRemove = null;

                while (currentElement != null)
                {
                    if (currentElement.Value.CompareTo(value) == 0)
                    {
                        elementToRemove = currentElement;

                        break;
                    }

                    previousElement = currentElement;
                    currentElement = currentElement.Next;
                }

                if (elementToRemove != null)
                {
                    previousElement.Next = elementToRemove.Next;

                    this.Count--;
                }
                else
                {
                    throw new InvalidOperationException("Cannot remove non-existing element.");
                }
            }
            else
            {
                throw new InvalidOperationException("Cannot remove from empty linked list.");
            }
        }

        public void RemoveFirst()
        {
            if (this.First != null)
            {
                this.First = this.First.Next;

                this.Count--;
            }
            else
            {
                throw new InvalidOperationException("Cannot remove from empty linked list.");
            }
        }

        public void RemoveLast()
        {
            if (this.First != null)
            {
                if (this.First.Next == null)
                {
                    this.First = null;

                    this.Count--;
                    return;
                }

                SinglyLinkedListNode<T> currentElement = this.First;
                SinglyLinkedListNode<T> previousElement = this.First;

                while (currentElement.Next != null)
                {
                    previousElement = currentElement;
                    currentElement = currentElement.Next;
                }

                previousElement.Next = null;

                this.Count--;
            }
            else
            {
                throw new InvalidOperationException("Cannot remove from empty linked list.");
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            if (this.First != null)
            {
                SinglyLinkedListNode<T> currentElement = this.First;

                while (currentElement != null)
                {
                    output.Append(currentElement.Value + " ");

                    currentElement = currentElement.Next;
                }
            }

            return output.ToString();
        }

        // Helper methods
        private void _InsertAfter(SinglyLinkedListNode<T> elementToAddAfter, SinglyLinkedListNode<T> elementToAdd)
        {
            SinglyLinkedListNode<T> nextElement = elementToAddAfter.Next;
            elementToAddAfter.Next = elementToAdd;

            if (nextElement != null)
            {
                elementToAdd.Next = nextElement;
            }

            this.Count++;
        }
    }

    public class SinglyLinkedListNode<T>
        where T : IComparable<T>
    {
        public T Value;
        public SinglyLinkedListNode<T> Next;

        public SinglyLinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}

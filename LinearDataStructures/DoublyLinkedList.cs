using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class DoublyLinkedList<T>
        where T : IComparable<T>
    {
        public DoublyLinkedListNode<T>? First;
        public DoublyLinkedListNode<T>? Last;
        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            this.First = null;
            this.Last = null;
            this.Count = 0;
        }

        public DoublyLinkedList(T value)
        {
            this.First = new DoublyLinkedListNode<T>(value);
            this.Last = this.First;
            this.Count = 1;
        }

        public void AddAfter(T elementToAddAfter, T value)
        {
            DoublyLinkedListNode<T> elementToAdd = new DoublyLinkedListNode<T>(value);

            if (this.First != null)
            {
                DoublyLinkedListNode<T> currentElement = this.First;

                while (currentElement != null)
                {
                    if (currentElement.Value.CompareTo(elementToAddAfter) == 0)
                    {
                        DoublyLinkedListNode<T> addBefore = currentElement.Next;

                        currentElement.Next = elementToAdd;
                        elementToAdd.Prev = currentElement;
                        elementToAdd.Next = addBefore;

                        if (addBefore != null)
                        {
                            addBefore.Prev = elementToAdd;
                        }

                        this.Count++;
                        return;
                    }

                    currentElement = currentElement.Next;
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
            DoublyLinkedListNode<T> elementToAdd = new DoublyLinkedListNode<T>(value);

            if (this.First != null)
            {
                elementToAdd.Next = this.First;
                this.First = elementToAdd;
            }
            else
            {
                this.First = elementToAdd;
                this.Last = this.First;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            DoublyLinkedListNode<T> elementToAdd = new DoublyLinkedListNode<T>(value);

            if (this.Last != null)
            {
                DoublyLinkedListNode<T> previousLastElement = this.Last;
                this.Last.Next = elementToAdd;
                this.Last = previousLastElement.Next;
                this.Last.Prev = previousLastElement;
            }
            else
            {
                this.Last = elementToAdd;
                this.First = this.Last;
            }

            this.Count++;
        }

        public void Clear()
        {
            this.First = null;
            this.Last = null;
            this.Count = 0;
        }

        public bool Contains(T value)
        {
            DoublyLinkedListNode<T> currentElement = this.First;

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

        public DoublyLinkedListNode<T> Find(T value)
        {
            if (this.First != null)
            {
                DoublyLinkedListNode<T> currentElement = this.First;

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
                DoublyLinkedListNode<T> currentElement = this.First;
                DoublyLinkedListNode<T> elementToRemove = null;

                while (currentElement != null)
                {
                    if (currentElement.Value.CompareTo(value) == 0)
                    {
                        elementToRemove = currentElement;

                        break;
                    }

                    currentElement = currentElement.Next;
                }

                if (elementToRemove != null)
                {
                    DoublyLinkedListNode<T> previousElement = elementToRemove.Prev;
                    DoublyLinkedListNode<T> nextElement = elementToRemove.Next;

                    if (previousElement == null)
                    {
                        this.First = nextElement;
                    }

                    if (nextElement == null)
                    {
                        this.Last = previousElement;
                    }

                    if (previousElement != null && nextElement != null)
                    {
                        previousElement.Next = nextElement;
                        nextElement.Prev = previousElement;
                    }

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
            if (this.Last != null)
            {
                this.Last.Prev.Next = null;
                this.Last = this.Last.Prev;
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
                DoublyLinkedListNode<T> currentElement = this.First;

                while (currentElement != null)
                {
                    output.Append(currentElement.Value + " ");

                    currentElement = currentElement.Next;
                }
            }

            return output.ToString();
        }
    }

    public class DoublyLinkedListNode<T>
        where T : IComparable<T>
    {
        public T Value;
        public DoublyLinkedListNode<T>? Next;
        public DoublyLinkedListNode<T>? Prev;

        public DoublyLinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
            this.Prev = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    public class Stack<T>
        where T : IComparable<T>
    {
        private List<T> _elements;
        private int _count;
        public int Count => this._count;

        public Stack()
        {
            this._elements = new List<T>();
            this._count = 0;
        }

        public void Clear()
        {
            this._elements = new List<T>();
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this._elements.Count; i++)
            {
                if (this._elements[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public T Peek()
        {
            if (this._count > 0)
            {
                return this._elements[this._count - 1];
            }

            throw new ArgumentOutOfRangeException("Cannot peek into empty stack.");
        }

        public T Pop()
        {
            if (this._count > 0)
            {
                T elementToReturn = this._elements[this._count - 1];
                this._count--;

                List<T> newElements = new List<T>();

                for (int i = 0; i < this._count; i++)
                {
                    newElements.Add(this._elements[i]);
                }

                this._elements = newElements;

                return elementToReturn;
            }

            throw new ArgumentOutOfRangeException("Cannot peek into empty stack.");
        }

        public void Push(T element)
        {
            this._elements.AddAt(this._count, element);
            this._count++;
        }

        public T[] ToArray()
        {
            T[] toArray = new T[this._count];

            for (int i = 0; i < this._elements.Count; i++)
            {
                toArray[i] = this._elements[i];
            }

            return toArray;

        }

        public override string ToString()
        {
            return this._elements.ToString();
        }
    }
}

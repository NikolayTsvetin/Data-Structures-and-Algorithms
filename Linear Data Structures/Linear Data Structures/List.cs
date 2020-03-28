using System;
using System.Text;

namespace Linear_Data_Structures
{
    public class List<T>
        where T : IComparable<T>
    {
        private T[] _elements;
        private int _count;
        private const int InitialSize = 4;
        public int Count => this._count;

        public List()
        {
            this._elements = new T[InitialSize];
            this._count = 0;
        }

        public T this[int index]
        {
            get
            {
                return this._elements[index];
            }
            set
            {
                this._elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this._count == this._elements.Length)
            {
                _Resize();
            }

            this._elements[_count] = element;
            this._count++;
        }

        public void AddAt(int index, T element)
        {
            T[] newArray = new T[this._count + 1];
            T[] realElements = _Shrink();

            if (index < 0 || index > this._count)
            {
                throw new ArgumentOutOfRangeException("Cannot add outside of bounds.");
            }

            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    newArray[i] = element;
                    this._count++;
                    continue;
                }

                newArray[i] = realElements[i];
            }

            if (index <= realElements.Length)
            {
                for (int i = index ; i < realElements.Length; i++)
                {
                    newArray[i + 1] = realElements[i];
                }
            }

            this._elements = newArray;
        }

        public void Clear()
        {
            this._elements = new T[InitialSize];
        }

        public bool Contains(T element)
        {
            int index = IndexOf(element);

            if (index >= 0)
            {
                return true;
            }

            return false;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this._elements.Length; i++)
            {
                if (this._elements[i].CompareTo(element) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Remove(T element)
        {
            int index = IndexOf(element);

            if (index >= 0)
            {
                RemoveAt(index);
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 || index < this._count)
            {
                T[] newArray = new T[this._count - 1];
                bool removed = false;
                T[] realElements = _Shrink();

                for (int i = 0; i < realElements.Length; i++)
                {
                    if (i == index)
                    {
                        removed = true;
                        continue;
                    }

                    if (removed)
                    {
                        newArray[i - 1] = realElements[i];
                    }
                    else
                    {
                        newArray[i] = realElements[i];
                    }
                }

                this._elements = newArray;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot remove outside the bounds.");
            }

            this._count--;
        }

        private void _Resize()
        {
            T[] newArray = new T[this._count * 2];

            for (int i = 0; i < this._elements.Length; i++)
            {
                newArray[i] = this._elements[i];
            }

            this._elements = newArray;
        }

        private T[] _Shrink()
        {
            T[] realElements = new T[this._count];

            for (int i = 0; i < this._count; i++)
            {
                realElements[i] = this._elements[i];
            }

            return realElements;
        }

        public T[] ToArray()
        {
            return this._elements;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            T[] realElements = _Shrink();

            for (int i = 0; i < realElements.Length; i++)
            {
                output.Append($"{realElements[i]} ");
            }

            return output.ToString().TrimEnd();
        }
    }
}

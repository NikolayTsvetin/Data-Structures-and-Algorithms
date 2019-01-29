using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MyStack<T>
        where T : IComparable<T>
    {
        public List<T> Elements { get; private set; }

        public MyStack()
        {
            Elements = new List<T>();
        }

        public void Clear()
        {
            Elements = new List<T>();
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return Elements.Count;
        }

        public T Peek()
        {
            try
            {
                return Elements[Elements.Count - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

                return default(T);
            }
        }

        public T Pop()
        {
            T elementToRemove = Elements[Elements.Count - 1];
            Elements.RemoveAt(Elements.Count - 1);

            return elementToRemove;
        }

        public void Push(T item)
        {
            Elements.Add(item);
        }

        public T[] ToArray()
        {
            T[] arrayToReturn = new T[Elements.Count];

            for (int i = 0; i < Elements.Count; i++)
            {
                arrayToReturn[Elements.Count - i - 1] = Elements[i];
            }

            return arrayToReturn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class MyQueue<T>
        where T : IComparable<T>
    {
        private List<T> Elements { get; set; }

        public MyQueue()
        {
            Elements = new List<T>();
        }

        public void Clean()
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

        public void Dequeue()
        {
            try
            {
                List<T> newElements = new List<T>();

                for (int i = 1; i < Elements.Count; i++)
                {
                    newElements.Add(Elements[i]);
                }

                Elements = newElements;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Enqueue(T item)
        {
            Elements.Add(item);
        }

        public T Peek()
        {
            return Elements[0];
        }

        public T[] ToArray()
        {
            T[] arrayToReturn = new T[Elements.Count];

            for (int i = 0; i < Elements.Count; i++)
            {
                arrayToReturn[i] = Elements[i];
            }

            return arrayToReturn;
        }

        public override string ToString()
        {
            return string.Join(", ", Elements);
        }
    }
}

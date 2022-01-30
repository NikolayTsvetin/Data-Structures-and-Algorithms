namespace LinearDataStructures
{
    public class Queue<T>
        where T : IComparable<T>
    {
        private List<T> _elements;
        private int _count;
        public int Count => this._count;

        public Queue()
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

        public T Dequeue()
        {
            if (this._count >= 0)
            {
                T elementToReturn = this._elements[0];

                for (int i = 1; i < this._elements.Count; i++)
                {
                    this._elements[i - 1] = this._elements[i];
                }

                this._elements.RemoveAt(this._elements.Count - 1);
                this._count--;

                return elementToReturn;
            }

            throw new InvalidOperationException("Cannot dequeue from empty queue.");
        }

        public void Enqueue(T element)
        {
            this._elements.AddAt(this._count, element);
            this._count++;
        }

        public T Peek()
        {
            return this._count > 0 ? this._elements[0] : throw new ArgumentOutOfRangeException("Cannot peek into empty queue.");
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

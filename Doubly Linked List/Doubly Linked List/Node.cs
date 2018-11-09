using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class Node<T>
    {
        public Node<T> Next { get; internal set; }
        public Node<T> Prev { get; internal set; }
        public T Value { get; internal set; }

        public Node(T value)
        {
            Next = null;
            Prev = null;
            Value = value;
        }
    }
}

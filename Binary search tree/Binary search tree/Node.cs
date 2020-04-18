using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node<T>
        where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }
}

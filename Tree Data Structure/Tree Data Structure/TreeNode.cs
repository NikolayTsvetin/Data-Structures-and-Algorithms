using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Data_Structure
{
    public class TreeNode<T>
        where T : IComparable<T>
    {
        public T Data { get; private set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void AddElement(T element)
        {
            if (Data.CompareTo(element) > 0)
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(element);
                }
                else
                {
                    Left.AddElement(element);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode<T>(element);
                }
                else
                {
                    Right.AddElement(element);
                }
            }
        }
    }
}

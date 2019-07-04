using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_tree
{
    public class TreeNode<T>
        where T : IComparable<T>
    {
        public T Data { get; private set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public bool IsRoot { get; private set; }

        public TreeNode(T data, bool isRoot = false)
        {
            Data = data;
            Left = null;
            Right = null;
            IsRoot = isRoot;
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

        public void FindAllLeafNodes()
        {
            if (Left == null && Right == null)
            {
                Console.WriteLine($"Leaf node found: {Data}");
            }

            if (Left != null)
            {
                Left.FindAllLeafNodes();
            }

            if (Right != null)
            {
                Right.FindAllLeafNodes();
            }
        }

        public void FindAllMiddleNodes()
        {
            if (Left != null)
            {
                Left.FindAllMiddleNodes();
            }

            if (Right != null)
            {
                Right.FindAllMiddleNodes();
            }

            // TODO: isRoot flag, DFS, call these methods from outside the class.

            if ((Left != null || Right != null) && !IsRoot)
            {
                Console.WriteLine($"Middle node found: {Data}");
            }
        }

        public void InOrderTraversal()
        {
            if (Left != null)
            {
                Left.InOrderTraversal();
            }

            Console.WriteLine(Data);

            if (Right != null)
            {
                Right.InOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (Left != null)
            {
                Left.PostOrderTraversal();
            }

            if (Right != null)
            {
                Right.PostOrderTraversal();
            }

            Console.WriteLine(Data);
        }

        public void PreOrderTraversal()
        {
            Console.WriteLine(Data);

            if (Left != null)
            {
                Left.PreOrderTraversal();
            }

            if (Right != null)
            {
                Right.PreOrderTraversal();
            }
        }

        public void BreadthFirstSearch()
        {
            Queue<TreeNode<T>> elements = new Queue<TreeNode<T>>();

            Console.WriteLine(Data);

            if (Left != null)
            {
                elements.Enqueue(Left);
            }

            if (Right != null)
            {
                elements.Enqueue(Right);
            }

            while (elements.Count > 0)
            {
                var nextNode = elements.Dequeue();

                Console.WriteLine(nextNode.Data);

                if (nextNode.Left != null)
                {
                    elements.Enqueue(nextNode.Left);
                }

                if (nextNode.Right != null)
                {
                    elements.Enqueue(nextNode.Right);
                }
            }
        }
    }
}

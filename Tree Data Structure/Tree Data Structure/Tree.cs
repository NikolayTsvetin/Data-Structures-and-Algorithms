using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Data_Structure
{
    public class Tree<T>
        where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T data, bool isRoot = false)
        {
            Root = new TreeNode<T>(data, isRoot);
        }

        public void AddElement(T element)
        {
            Root.AddElement(element);
        }

        public void FindAllLeafNodes()
        {
            Root.FindAllLeafNodes();
        }

        public void FindAllMiddleNodes()
        {
            Root.FindAllMiddleNodes();
        }

        public void InOrderTraversal()
        {
            Root.InOrderTraversal();
        }

        public void PostOrderTraversal()
        {
            Root.PostOrderTraversal();
        }

        public void PreOrderTraversal()
        {
            Root.PreOrderTraversal();
        }
    }
}

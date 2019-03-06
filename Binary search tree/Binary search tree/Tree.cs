using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_tree
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

        public int Height(TreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return (1 + Math.Max(Height(node.Left), Height(node.Right)));
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

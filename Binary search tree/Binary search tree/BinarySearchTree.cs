using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        Node<T> Root;

        public BinarySearchTree()
        {
        }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);

                return;
            }

            Add(Root, data);
        }

        private void Add(Node<T> root, T data)
        {
            if (root.Data.CompareTo(data) <= 0)
            {
                if (root.Right == null)
                {
                    root.Right = new Node<T>(data);

                    return;
                }

                Add(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {
                    root.Left = new Node<T>(data);

                    return;
                }

                Add(root.Left, data);
            }
        }

        public bool Exists(T data)
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Cannot search in empty tree.");
            }

            bool result = Exists(Root, data);

            return result;
        }

        private bool Exists(Node<T> root, T data)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Data.CompareTo(data) == 0)
            {
                return true;
            }

            bool leftSubTreeResult = Exists(root.Left, data);
            bool rightSubTreeResult = Exists(root.Right, data);

            return leftSubTreeResult || rightSubTreeResult;
        }

        public Node<T> Find(T data)
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Cannot search in empty tree.");
            }

            Node<T> result = Find(Root, data);

            return result;
        }

        private Node<T> Find(Node<T> root, T data)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Data.CompareTo(data) == 0)
            {
                return root;
            }

            Node<T> leftSubTreeResult = Find(root.Left, data);
            Node<T> rightSubTreeResult = Find(root.Right, data);

            return leftSubTreeResult != null ? leftSubTreeResult : rightSubTreeResult;
        }

        //public IEnumerable<Node<T>> Find(Func<Node<T>, bool> predicate)
        //{
        //    if (Root == null)
        //    {
        //        throw new InvalidOperationException("Cannot search in empty tree.");
        //    }

        //    IEnumerable<Node<T>> result = Find(Root, predicate);

        //    return result;
        //}

        //private IEnumerable<Node<T>> Find(Node<T> root, Func<Node<T>, bool> predicate)
        //{
        //    if (root == null)
        //    {
        //        yield break;
        //    }

        //    if (predicate(root))
        //    {
        //        yield return root;
        //    }

        //    Find(root.Left, predicate);
        //    Find(root.Right, predicate);
        //}

        public void GetLeafNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Cannot traverse empty tree.");
            }

            GetLeafNodes(Root);
        }

        private void GetLeafNodes(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine($"Leaf node found: {root.Data}");
            }

            GetLeafNodes(root.Left);
            GetLeafNodes(root.Right);
        }

        public Node<T> GetRoot()
        {
            if (Root != null)
            {
                return Root;
            }

            throw new NullReferenceException("There is no root element.");
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
        }

        private void InOrderTraversal(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.Left);
            Console.WriteLine($"Element: {root.Data}");
            InOrderTraversal(root.Right);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
        }

        private void PostOrderTraversal(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.WriteLine($"Element: {root.Data}");
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
        }

        private void PreOrderTraversal(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine($"Element: {root.Data}");

            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        // TODO: Get depth, Find (predicate ?), yield return leaf.
    }
}

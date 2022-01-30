namespace BinarySearchTree
{
    public class BinarySearchTree<T>
        where T : IComparable<T>
    {
        Node<T>? Root;

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

        public int GetDepth()
        {
            if (Root == null)
            {
                return 0;
            }

            int depth = GetDepth(Root);

            return depth;
        }

        private int GetDepth(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftSubTreeDepth = GetDepth(root.Left);
            int rightSubTreeDepth = GetDepth(root.Right);

            return leftSubTreeDepth > rightSubTreeDepth ? leftSubTreeDepth + 1 : rightSubTreeDepth + 1;
        }

        public List<Node<T>> GetLeafNodes()
        {
            if (Root == null)
            {
                throw new InvalidOperationException("Cannot traverse empty tree.");
            }

            List<Node<T>> allLeafNodes = new List<Node<T>>();

            GetLeafNodes(Root.Left, allLeafNodes);
            GetLeafNodes(Root.Right, allLeafNodes);

            return allLeafNodes;
        }

        private void GetLeafNodes(Node<T> root, List<Node<T>> allLeafNodes)
        {
            if (root == null)
            {
                return;
            }

            if (root.Left == null && root.Right == null)
            {
                allLeafNodes.Add(root);
            }
            else
            {
                allLeafNodes.Add(root);

                GetLeafNodes(root.Left, allLeafNodes);
                GetLeafNodes(root.Right, allLeafNodes);
            }

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
    }
}

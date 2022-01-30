namespace BinarySearchTree
{
    public class Node<T>
        where T : IComparable<T>
    {
        public T Data;
        public Node<T>? Left;
        public Node<T>? Right;

        public Node(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }
}
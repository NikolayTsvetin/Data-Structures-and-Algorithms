using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        //Node left;
        //Node right;
        //int data;
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public void insert(int value)
        {
            if (value <= Data)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.insert(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.insert(value);
                }
            }
        }

        public bool contains(int value)
        {
            if (value == Data)
            {
                return true;
            }
            else if (value < Data)
            {
                if (Left == null)
                {
                    return false;
                }
                else
                {
                    return Left.contains(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    return false;
                }
                else
                {
                    return Right.contains(value);
                }
            }
        }

        public void inOrderTraversal()
        {
            if (Left != null)
            {
                Left.inOrderTraversal();
            }

            Console.WriteLine(Data);

            if (Right != null)
            {
                Right.inOrderTraversal();
            }
        }

        public void preOrderTraversal()
        {
            Console.WriteLine(Data);

            if (Left != null)
            {
                Left.preOrderTraversal();
            }

            if (Right != null)
            {
                Right.preOrderTraversal();
            }
        }

        public void postOrderTraversal()
        {
            Console.WriteLine(Data);

            if (Left != null)
            {
                Left.postOrderTraversal();
            }

            if (Right != null)
            {
                Right.postOrderTraversal();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node bst = new Node(10);

            bst.insert(5);
            bst.insert(15);
            bst.insert(38);
            bst.insert(3);
            bst.insert(14);

            Console.WriteLine("IN ORDER TRAVERSAL");
            bst.inOrderTraversal();
            Console.WriteLine("PRE ORDER TRAVERSAL");
            bst.preOrderTraversal();
            Console.WriteLine("POST ORDER TRAVERSAL");
            bst.postOrderTraversal();
        }
    }
}

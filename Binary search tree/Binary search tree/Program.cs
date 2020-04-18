using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(1);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(10);
            tree.Add(5);
            tree.Add(8);

            tree.GetLeafNodes();
            //var x = tree.Find(item => item.Data.CompareTo(5) == 0);
        }
    }
}

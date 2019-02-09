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

        public Tree(T data)
        {
            Root = new TreeNode<T>(data);
        }

        public void AddElement(T element)
        {
            Root.AddElement(element);
        }

        public void Print(TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.Data);

                Print(root.Left);
                Print(root.Right);
            }
        }
    }
}

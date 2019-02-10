using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(12, true);

            tree.AddElement(8);
            tree.AddElement(18);
            tree.AddElement(5);
            tree.AddElement(4);
            tree.AddElement(11);
            tree.AddElement(17);

            //Console.WriteLine("--- InOrderTraversal ---");
            //tree.InOrderTraversal();

            //Console.WriteLine("--- PostOrderTraversal ---");
            //tree.PostOrderTraversal();

            //Console.WriteLine("--- PreOrderTraversal ---");
            //tree.PreOrderTraversal();

            Console.WriteLine("--- All leaf nodes ---");
            tree.FindAllLeafNodes();

            Console.WriteLine("--- All middle nodes ---");
            tree.FindAllMiddleNodes();
        }
    }
}

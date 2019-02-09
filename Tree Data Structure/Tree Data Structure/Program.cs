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
            Tree<int> tree = new Tree<int>(5);

            tree.AddElement(3);
            tree.AddElement(13);
            tree.AddElement(0);
            tree.AddElement(23);
            tree.AddElement(1);

            tree.Print(tree.Root);
        }
    }
}

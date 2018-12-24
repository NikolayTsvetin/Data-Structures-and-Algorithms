using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectLoopInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool hasCycle(SinglyLinkedListNode head)
        {
            var currentEl = head;
            Dictionary<SinglyLinkedListNode, int> dict = new Dictionary<SinglyLinkedListNode, int>();

            if (head == null)
            {
                return false;
            }

            while (currentEl.Next != null)
            {
                if (!dict.ContainsKey(currentEl))
                {
                    dict.Add(currentEl, currentEl.Data);
                }
                else
                {
                    return true;
                }

                currentEl = currentEl.Next;
            }

            return false;
        }
    }
}

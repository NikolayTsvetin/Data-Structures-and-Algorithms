namespace DetectLoopInLinkedList
{
    internal class SinglyLinkedListNode
    {
        public int Data { get; set; }
        public SinglyLinkedListNode Next { get; set; }

        public SinglyLinkedListNode(int data)
        {
            Data = data;
        }
    }
}
namespace LinkedListProblems;
internal class RemoveDuplicatesFromLinkedList
{
    public class Program
    {
        // This is an input class. Do not edit.
        public class LinkedList
        {
            public int value;
            public LinkedList? next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            var currentNode = linkedList;
            while (currentNode != null)
            {
                var currentValue = linkedList.value;
                var nextNode = currentNode.next;
                while (nextNode != null && currentValue == nextNode.value)
                {
                    nextNode = nextNode.next;
                }
                currentNode.next = nextNode;
                currentNode = nextNode;
            }

            return linkedList;
        }
    }
}

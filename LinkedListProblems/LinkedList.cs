namespace LinkedListProblems;
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

    public static void RemoveKthNodeFromEnd(LinkedList head, int k)
    {
        var current = head;
        var follower = head;

        var currentPos = 0;
        while (currentPos < k)
        {
            current = current!.next;
            currentPos++;
        }

        if (current == null)
        {
            if (head.next != null)
            {
                head.value = head.next.value;
                head.next = head.next.next;
            }
            return;
        }

        while (current.next != null)
        {
            follower = follower!.next;
            current = current.next;
        }

        follower!.next = follower.next!.next;
    }
}


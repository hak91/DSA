
public class DoublyLinkedList
{
    public Node? Head;
    public Node? Tail;

    public void SetHead(Node node)
    {
        if (node == null)
        {
            return;
        }
        this.Remove(node);
        node.Next = this.Head;
        if (this.Head != null)
        {
            this.Head.Prev = node;
        }
        this.Head = node;
    }

    public void SetTail(Node node)
    {
        if (node == null)
        {
            return;
        }
        this.Remove(node);
        node.Prev = this.Tail;
        if (this.Tail != null)
        {
            this.Tail.Next = node;
        }
        node.Next = null;
        this.Tail = node;
    }

    public void InsertBefore(Node node, Node nodeToInsert)
    {
        nodeToInsert.Next = node;
        nodeToInsert.Prev = node.Prev;
        node.Prev = nodeToInsert;
    }

    public void InsertAfter(Node node, Node nodeToInsert)
    {
        nodeToInsert.Next = node.Next;
        node.Next = nodeToInsert;
        nodeToInsert.Prev = node;
    }

    public void InsertAtPosition(int position, Node nodeToInsert)
    {
        var currentNode = this.Head;
        for (var nodePos = 0; nodePos < position - 1; nodePos++)
        {
            if (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
            }
        }

        this.InsertAfter(currentNode, nodeToInsert);
    }

    public void RemoveNodesWithValue(int value)
    {
        var currentNode = this.Head;
        while (currentNode != null)
        {
            var nextNode = currentNode.Next;
            if (currentNode.Value == value)
            {
                this.Remove(currentNode);
            }
            currentNode = nextNode;
        }
    }

    public void Remove(Node node)
    {
        var previousNode = node.Prev;
        var nextNode = node.Next;

        if (previousNode != null)
        {
            previousNode.Next = nextNode;
        }
        if (nextNode != null)
        {
            nextNode.Prev = previousNode;
        }

        node.Prev = null;
        node.Next = null;
    }

    public bool ContainsNodeWithValue(int value)
    {
        var currentNode = this.Head;
        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return true;
            }
            currentNode = currentNode.Next;
        }
        return false;
    }
}

// Do not edit the class below.

public class Node
{
    public int Value;
    public Node? Prev;
    public Node? Next;

    public Node(int value)
    {
        this.Value = value;
    }
}

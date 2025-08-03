namespace DsaUnitTests.LinkedLists;

public class DoublyLinkedListTests
{
    private List<int> GetNodeValuesHeadToTail(DoublyLinkedList linkedList)
    {
        var values = new List<int>();
        var node = linkedList.Head;
        while (node != null)
        {
            values.Add(node.Value);
            node = node.Next;
        }
        return values;
    }

    private List<int> GetNodeValuesTailToHead(DoublyLinkedList linkedList)
    {
        var values = new List<int>();
        var node = linkedList.Tail;
        while (node != null)
        {
            values.Add(node.Value);
            node = node.Prev;
        }
        return values;
    }

    private void BindNodes(Node nodeOne, Node nodeTwo)
    {
        nodeOne.Next = nodeTwo;
        nodeTwo.Prev = nodeOne;
    }

    [Fact]
    public void TestDoublyLinkedListOperations()
    {
        // Arrange
        var linkedList = new DoublyLinkedList();
        var one = new Node(1);
        var two = new Node(2);
        var three = new Node(3);
        var three2 = new Node(3);
        var three3 = new Node(3);
        var four = new Node(4);
        var five = new Node(5);
        var six = new Node(6);

        this.BindNodes(one, two);
        this.BindNodes(two, three);
        this.BindNodes(three, four);
        this.BindNodes(four, five);
        linkedList.Head = one;
        linkedList.Tail = five;

        // Act & Assert
        linkedList.SetHead(four);
        Assert.Equal(new[] { 4, 1, 2, 3, 5 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 5, 3, 2, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.SetTail(six);
        Assert.Equal(new[] { 4, 1, 2, 3, 5, 6 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 6, 5, 3, 2, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.InsertBefore(six, three);
        Assert.Equal(new[] { 4, 1, 2, 5, 3, 6 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 6, 3, 5, 2, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.InsertAfter(six, three2);
        Assert.Equal(new[] { 4, 1, 2, 5, 3, 6, 3 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 3, 6, 3, 5, 2, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.InsertAtPosition(1, three3);
        Assert.Equal(new[] { 3, 4, 1, 2, 5, 3, 6, 3 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 3, 6, 3, 5, 2, 1, 4, 3 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.RemoveNodesWithValue(3);
        Assert.Equal(new[] { 4, 1, 2, 5, 6 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 6, 5, 2, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        linkedList.Remove(two);
        Assert.Equal(new[] { 4, 1, 5, 6 }, this.GetNodeValuesHeadToTail(linkedList));
        Assert.Equal(new[] { 6, 5, 1, 4 }, this.GetNodeValuesTailToHead(linkedList));

        Assert.True(linkedList.ContainsNodeWithValue(5));
    }

    [Fact]
    public void ContainsNodeWithValue_ReturnsFalse_WhenValueNotFound()
    {
        // Arrange
        var linkedList = new DoublyLinkedList();
        var node = new Node(1);
        linkedList.Head = node;
        linkedList.Tail = node;

        // Act & Assert
        Assert.False(linkedList.ContainsNodeWithValue(2));
    }

    [Fact]
    public void InsertAtPosition_FirstPosition_InsertsAtHead()
    {
        // Arrange
        var linkedList = new DoublyLinkedList();
        var one = new Node(1);
        linkedList.Head = one;
        linkedList.Tail = one;
        var newNode = new Node(2);

        // Act
        linkedList.InsertAtPosition(0, newNode);

        // Assert
        Assert.Equal(new[] { 2, 1 }, this.GetNodeValuesHeadToTail(linkedList));
    }
}


using LinkedListProblems;

namespace DsaUnitTests.LinkedLists;

public class LinkedListRecursiveReverserTests
{
    [Fact]
    public void ReverseLinkedList_ShouldReverseList()
    {
        // Arrange
        var test = new TestLinkedList(1);
        test.AddMany(new int[] { 2, 3, 4, 5 });
        int[] expected = { 5, 4, 3, 2, 1 };
        // Act
        var reversed = LinkedListRecursiveReverser.Solution.ReverseList(test);
        // Assert
        Assert.True(this.Compare(reversed, expected));
    }

    private bool Compare(ListNode head, int[] arr2)
    {
        while (head != null && arr2.Length > 0)
        {
            if (head.val != arr2[0])
            {
                return false;
            }
            head = head.next;
            arr2 = arr2[1..];
        }
        return true;
    }

    public class TestLinkedList : ListNode
    {
        public TestLinkedList(int value) : base(value) { }
        public void AddMany(int[] values)
        {
            ListNode current = this;
            while (current.next != null)
            {
                current = current.next;
            }
            foreach (var value in values)
            {
                current.next = new ListNode(value);
                current = current.next;
            }
        }
        public List<int> GetNodesInArray()
        {
            var array = new List<int>();
            ListNode? currentNode = this;
            while (currentNode != null)
            {
                array.Add(currentNode.val);
                currentNode = currentNode.next;
            }
            return array;
        }
    }
}

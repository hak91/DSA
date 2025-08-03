using LinkedListProblems;

namespace LinkedLists;
public class RemoveKthNodeFromEndTests
{
    [Fact]
    public void RemoveKthNodeFromEnd_ShouldRemoveFourthNodeFromEnd()
    {
        // Arrange
        var test = new TestLinkedList(0);
        test.AddMany(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        int[] expected = { 0, 1, 2, 3, 4, 5, 7, 8, 9 };

        // Act
        LinkedList.RemoveKthNodeFromEnd(test, 4);

        // Assert
        Assert.True(this.Compare(test.GetNodesInArray(), expected));
    }

    [Fact]
    public void RemoveKthNodeFromEnd_ShouldMutateHead()
    {
        // Arrange
        var test = new TestLinkedList(0);
        test.AddMany([1, 2, 3]);
        int[] expected = [1, 2, 3];

        // Act
        LinkedList.RemoveKthNodeFromEnd(test, 4);

        //Assert
        Assert.True(test.GetNodesInArray().SequenceEqual(expected));
    }

    private bool Compare(List<int> arr1, int[] arr2)
    {
        if (arr1.Count != arr2.Length)
        {
            return false;
        }
        for (int i = 0; i < arr1.Count; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }

    private class TestLinkedList : LinkedList
    {
        public TestLinkedList(int value) : base(value) { }

        public void AddMany(int[] values)
        {
            LinkedList current = this;
            while (current.next != null)
            {
                current = current.next;
            }
            foreach (int value in values)
            {
                current.next = new LinkedList(value);
                current = current.next;
            }
        }

        public List<int> GetNodesInArray()
        {
            List<int> nodes = new List<int>();
            LinkedList? current = this;
            while (current != null)
            {
                nodes.Add(current.value);
                current = current.next;
            }
            return nodes;
        }
    }
}






namespace LinkedListProblems;

public class LinkedListElementRemover
{
    public class Solution
    {
            public ListNode RemoveElements(ListNode head, int val)
            {
                var updatedHead = this.RemoveElementsRecursive(head, val);
                return updatedHead;
            }

            private ListNode RemoveElementsRecursive(ListNode? head, int val)
            {
                if (head is null)
                {
                    return head;
                }

                var next = this.RemoveElementsRecursive(head.next, val);

                if (head.val == val)
                {
                    return next;
                }
                head.next = next;
                return head;
            }
    }
}

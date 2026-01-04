// See https://aka.ms/new-console-template for more information
using LinkedListProblems;

public class LinkedListRecursiveReverser
{
    public static class Solution
    {
        public static ListNode ReverseList(ListNode head)
        {
            if(head.next == null)
            {
                return head;
            }

            var reversedList = ReverseList(head.next);

            head.next.next = head;
            head.next = null;

            return reversedList;
        }
    }
}

public class LinkedListRecursiveReverser2
{
    public class Solution
    {
        private ListNode? _reversedHead;

        public ListNode? ReverseList(ListNode head)
        {
            if (head == null) return head;
            var last = this.RecursionReverse(head);
            last.next = null;

            return this._reversedHead;
        }

        public ListNode RecursionReverse(ListNode node)
        {
            if (node.next == null)
            {
                this._reversedHead = node;
                return node;
            }
            var next = this.RecursionReverse(node.next);
            next.next = node;
            return node;

        }
    }
}
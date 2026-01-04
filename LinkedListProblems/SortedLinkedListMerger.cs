
namespace LinkedListProblems;

public class SortedLinkedListMerger
{
    public class Solution
    {
        public ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode? result = null;

            this.MergeTwoListsRecursive(list1, list2, ref result);

            return result;
        }

        private void MergeTwoListsRecursive(ListNode? list1, ListNode? list2, ref ListNode? result)
        {
            if (list1 is null && list2 is null)
            {
                return;
            }

            if (list1 is null)
            {
                result = list2;
                return;
            }

            if (list2 is null)
            {
                result = list1;
                return;
            }

            if (list1.val < list2.val)
            {
                this.MergeTwoListsRecursive(list1.next, list2, ref result);
                result = new ListNode(list1.val, result);
                return;
            }

            this.MergeTwoListsRecursive(list1, list2.next, ref result);
            result = new ListNode(list2.val, result);
            return;
        }
    }
}

namespace LinkedListProblems;

public class IsPalindromeCalculator
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            var end = head;

            var result = this.IsPalindromeRecursive(head, ref end);

            return result;
        }

        private bool IsPalindromeRecursive(ListNode? head, ref ListNode? end)
        {
            if (head is null)
            {
                return true;
            }

            var isPalindromeSoFar = this.IsPalindromeRecursive(head.next, ref end);

            var isPalinDrome = isPalindromeSoFar && head.val == end.val;

            end = end.next;

            return isPalinDrome;
        }
    }

}


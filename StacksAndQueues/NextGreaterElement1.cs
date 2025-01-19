namespace StacksAndQueues;

public class NextGreaterElement1
{
    public class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nextGreaterElements = new int[nums1.Length];
            var greaterNumsStack = new Stack<int>();

            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                while (greaterNumsStack.Count > 0 &&
                       greaterNumsStack.Peek() < nums2[i])
                {
                    greaterNumsStack.Pop();
                }

                if (nums1.Contains(nums2[i]))
                {
                    var idx = Array.IndexOf(nums1, nums2[i]);
                    if (greaterNumsStack.Count > 0)
                    {
                        nextGreaterElements[idx] = greaterNumsStack.Peek();
                    }
                    else
                    {
                        nextGreaterElements[idx] = -1;
                    }
                }

                greaterNumsStack.Push(nums2[i]);
            }
            return nextGreaterElements;
        }
    }

    public Solution MySolution { get; }

    public NextGreaterElement1()
    {
        this.MySolution = new Solution();
    }
}
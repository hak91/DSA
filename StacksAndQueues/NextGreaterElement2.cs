namespace StacksAndQueues
{
    public class NextGreaterElement2
    {
        public static Solution MySolution = new Solution();
        public class Solution
        {
            public int[] NextGreaterElements(int[] nums)
            {
                var nextGreaterElements = Enumerable.Repeat(-1, nums.Length).ToArray();
                var greaterNumsStack = new Stack<int>();

                for (int i = 2 * nums.Length - 1; i >= 0; i--)
                {
                    while (greaterNumsStack.Count > 0 &&
                           greaterNumsStack.Peek() <= nums[i % nums.Length])
                    {
                        greaterNumsStack.Pop();
                    }

                    if (i < nums.Length && greaterNumsStack.Count > 0)
                    {
                        nextGreaterElements[i] = greaterNumsStack.Peek();
                    }

                    greaterNumsStack.Push(nums[i % nums.Length]);
                }
                return nextGreaterElements;
            }
        }
    }
}

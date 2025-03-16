namespace ArrayProblems;

public class ZeroSumSubarray
{
    public class Program
    {
        public bool ZeroSumSubarray(int[] nums)
        {
            var sumsCount = new Dictionary<int, int>();
            var currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (!sumsCount.ContainsKey(currentSum))
                {
                    sumsCount[currentSum] = 0;
                }
                sumsCount[currentSum]++;
                if (sumsCount[currentSum] > 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

namespace ArrayProblems;
internal class TwoSumHastTable
{
    public class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            var mapping = new Dictionary<int, bool>();
            foreach (var num in array)
            {
                var difference = targetSum - num;
                if (mapping.ContainsKey(difference))
                {
                    return new int[] { difference, num };
                }
                else
                {
                    mapping[num] = true;
                }
            }
            return new int[0];
        }
    }
}

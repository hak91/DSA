namespace ArrayProblems;

internal class TwoSumBruteForce
{
    public class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return [array[i], array[j]];
                    }
                }
            }
            return [];
        }
    }
}

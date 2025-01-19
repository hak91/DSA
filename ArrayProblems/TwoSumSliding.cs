namespace ArrayProblems;

internal class TwoSumSliding
{
    public class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);

            var left = 0;
            var right = array.Length - 1;

            while (true)
            {
                if (array[left] + array[right] == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }

                if (right - left == 1)
                {
                    break;
                }

                if (array[left] + array[right] < targetSum)
                {
                    left++;
                    continue;
                }

                if (array[left] + array[right] > targetSum)
                {
                    right--;
                    continue;
                }
            }

            return new int[0];
        }
    }
}

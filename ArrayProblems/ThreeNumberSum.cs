namespace ArrayProblems;
public class ThreeNumberSum
{
    public class Program
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            var result = new List<int[]>();
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                int[] subArray = new int[array.Length - i - 1];
                for (int j = 0; j < subArray.Length; j++)
                {
                    subArray[j] = array[i + 1 + j];
                }
                var sumsForCurrent = TwoNumberSum(subArray, targetSum - current);
                foreach (var sumOfCurrent in sumsForCurrent)
                {
                    if (sumOfCurrent.Length > 0)
                    {
                        result.Add(new int[] { current, sumOfCurrent[0], sumOfCurrent[1] });
                    }
                }
            }
            return result;
        }

        private static List<int[]> TwoNumberSum(int[] array, int targetSum)
        {
            var result = new List<int[]>();
            var left = 0;
            var right = array.Length - 1;

            while (left < right)
            {
                if (array[left] + array[right] == targetSum)
                {
                    result.Add(new int[] { array[left], array[right] });
                    left++;
                    right--;
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

            return result;
        }
    }
}

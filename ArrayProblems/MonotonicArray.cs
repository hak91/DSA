namespace ArrayProblems;
internal class MonotonicArray
{
    public class Program
    {
        public static bool IsMonotonic(int[] array)
        {
            if (array.Length == 0)
            {
                return true;
            }
            bool supposedIncreasing = false, supposedDecreasing = false;
            if (array[0] < array[array.Length - 1])
                supposedIncreasing = true;
            else
                supposedDecreasing = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1] && supposedDecreasing)
                {
                    return false;
                }
                if (array[i] > array[i + 1] && supposedIncreasing)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

namespace ArrayProblems;

internal class SortedSquaredArraySolution2
{
    public class Program
    {
        public int[] SortedSquaredArray(int[] array)
        {
            var result = new int[array.Length];
            var start = 0;
            var end = array.Length - 1;
            var idx = array.Length - 1;
            while (idx >= 0)
            {
                if (Math.Abs(array[start]) > Math.Abs(array[end]))
                {
                    result[idx] = array[start] * array[start];
                    start++;
                }
                else
                {
                    result[idx] = array[end] * array[end];
                    end--;
                }
                idx--;
            }
            return result;
        }
    }

}

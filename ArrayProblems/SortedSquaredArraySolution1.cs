namespace ArrayProblems;
internal class SortedSquaredArraySolution1
{
    public class Program
    {
        public int[] SortedSquaredArray(int[] array)
        {
            var result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] * array[i];
            }

            Array.Sort(result);
            return result;
        }
    }

}

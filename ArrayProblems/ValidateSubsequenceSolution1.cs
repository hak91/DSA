namespace ArrayProblems;
internal class ValidateSubsequenceSolution1
{
    public class Program
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            var currentIndex = 0;

            for (var i = 0; i < array.Count; i++)
            {
                if (sequence[currentIndex] == array[i])
                {
                    currentIndex++;
                }
                if (currentIndex == sequence.Count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

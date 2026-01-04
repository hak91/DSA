namespace RecursionProblems;

public class IsPowerOfTwoRecursiveCalculator
{
    public static class Solution
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n ==1 )
            {
                return true;
            }
            if (n == 0)
            {
                return false;
            }
            return IsPowerOfTwoRecursive(n);
        }

        private static bool IsPowerOfTwoRecursive(int n)
        {
            if (n % 2 != 0)
            {
                return false;
            }
            
            if (n / 2 == 1)
            {
                return true;
            }
            return IsPowerOfTwoRecursive(n / 2);
        }
    }
}
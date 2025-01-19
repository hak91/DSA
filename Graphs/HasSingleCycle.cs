namespace Graphs;
internal class HasSingleCycle
{
    public class Program
    {
        public static bool HasSingleCycle(int[] array)
        {
            var countUntilCycle = 1;
            var currentIndex = 0;
            while (countUntilCycle <= array.Length + 1)
            {
                var nextIndex = (array.Length + (array.Length + currentIndex + array[currentIndex]) % array.Length) % array.Length;
                countUntilCycle++;
                if (nextIndex == 0)
                {
                    if (countUntilCycle == array.Length + 1)
                        return true;
                    else
                        return false;
                }
                currentIndex = nextIndex;
            }
            return false;
        }
    }
}

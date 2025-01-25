namespace ArrayProblems;
public class BestSeat
{
    public Program MyProgram => new Program();
    public class Program
    {
        public int BestSeat(int[] seats)
        {
            var bestSeat = -1;
            var left = 0;
            var maxSpace = 0;
            while (left < seats.Length)
            {
                var right = left + 1;
                while (right < seats.Length && seats[right] == 0)
                {
                    right++;
                }

                var availableSpace = right - left - 1;
                if (availableSpace > maxSpace)
                {
                    maxSpace = availableSpace;
                    bestSeat = (left + right) / 2;
                }
                left = right;
            }
            return bestSeat;
        }
    }
}

namespace ArrayProblems;
internal class MergeOverlappingIntervals
{
    public class Program
    {
        public static int[][] MergeOverlappingIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            List<int[]> result = new List<int[]>();

            var currentInterval = intervals[0];
            result.Add(currentInterval);
            foreach (var nextInterval in intervals)
            {
                var currentIntervalEnd = currentInterval[1];
                var nextIntervalEnd = nextInterval[1];
                var nextIntervalStart = nextInterval[0];
                if (currentIntervalEnd >= nextIntervalStart)
                {
                    currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
                }
                else
                {
                    result.Add(nextInterval);
                    currentInterval = nextInterval;
                }
            }
            return result.ToArray();
        }
    }
}

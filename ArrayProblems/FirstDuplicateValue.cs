namespace ArrayProblems;
internal class FirstDuplicateValue
{
    public class Program
    {
        public int FirstDuplicateValue(int[] array)
        {
            HashSet<int> values = new();

            foreach (var value in array)
            {
                if (values.Contains(value))
                {
                    return value;
                }
                values.Add(value);
            }
            return -1;
        }

    }
}

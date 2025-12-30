namespace DynamicProgramming;
public class TextJustification
{
    public void Run(string[] words, int lineWidth)
    {
        var result = this.Badness(words, lineWidth, 0);

        Console.WriteLine($"Result: {result}");
    }

    private int Badness(IEnumerable<string> words, int lineWidth, int i)
    {
        if (i == words.Count() - 1)
        {
            return 0;
        }
        int minimum = int.MaxValue;
        for (int j = i + 1; j < words.Count(); j++)
        {
            var badness = this.BadnessFor(words.Skip(i).Take(j), lineWidth);
            var badnessOfSuffix = this.Badness(words, lineWidth, j);
            if (badness + badnessOfSuffix <= minimum)
            {
                minimum = badness + badnessOfSuffix;
            }
        }
        return minimum;
    }

    private int BadnessFor(IEnumerable<string> words, int lineWidth)
    {
        var length = words.Sum(w => w.Length) + words.Count() - 1;

        if (length > lineWidth)
        {
            return int.MaxValue;
        }
        return (int)Math.Pow((lineWidth - length), 3);
    }
}

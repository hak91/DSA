namespace SortingAlgorithms;

public class MergeSortAlgorithm : ISortingAlgorithm
{
    public List<int> Sort(List<int> myList)
    {
        if (myList.Count < 2)
        {
            return myList;
        }
        var numberOfElements = myList.Count;

        var firstHalf = myList.GetRange(0, (numberOfElements / 2));
        var left = this.Sort(firstHalf);

        var secondHalf = myList.GetRange((numberOfElements / 2), numberOfElements - (numberOfElements / 2));
        var right = this.Sort(secondHalf);

        return this.Merge(left, right);

    }

    private List<int> Merge(List<int> left, List<int> right)
    {
        var mergedList = new List<int>();
        var leftIndex = 0;
        var rightIndex = 0;
        var leftSize = left.Count;
        var rightSize = right.Count;
        while (leftIndex < leftSize || rightIndex < rightSize)
        {
            if (rightIndex == rightSize || (leftIndex < leftSize && left[leftIndex] < right[rightIndex]))
            {
                mergedList.Add(left[leftIndex++]);
            }
            else
            {
                mergedList.Add(right[rightIndex++]);
            }
        }
        return mergedList;
    }
}
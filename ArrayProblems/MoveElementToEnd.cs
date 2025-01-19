namespace ArrayProblems;
internal class MoveElementToEnd
{
    public class Program
    {
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            var left = 0;
            var right = array.Count - 1;

            while (left < right)
            {
                while (left < right && array[right] == toMove) { right--; }
                if (left == toMove)
                {
                    array[left] = array[right];
                    array[right] = toMove;
                }
                left++;
            }
            return array;
        }
    }
}

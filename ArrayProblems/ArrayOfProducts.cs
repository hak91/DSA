namespace ArrayProblems;
internal class ArrayOfProducts
{
    public class Program
    {
        public static int[] ArrayOfProducts(int[] array)
        {
            var leftToRight = new int[array.Length];
            var rightToLeft = new int[array.Length];
            var product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
                leftToRight[i] = product;
            }
            product = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                product *= array[i];
                rightToLeft[i] = product;
            }

            var result = new int[array.Length];
            if (result.Length > 0)
            {
                result[0] = rightToLeft[1];
            }
            if (result.Length > 1)
            {
                result[array.Length - 1] = leftToRight[array.Length - 2];
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                result[i] = leftToRight[i - 1] * rightToLeft[i + 1];
            }

            return result;
        }
    }
}

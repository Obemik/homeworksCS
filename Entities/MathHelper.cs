namespace ClassApp
{
    internal static class MathHelper
    {
        public static int GetProductInRange(int start, int end)
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
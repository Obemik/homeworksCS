namespace ClassApp
{
    internal static class MathHelper
    {
        public static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
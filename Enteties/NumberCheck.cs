namespace ClassApp
{
    internal static class NumberCheck
    {
        public static bool IsFibonacci(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Число не може бути від'ємним");
            }

            return MathHelper.IsPerfectSquare(5 * number * number + 4) || MathHelper.IsPerfectSquare(5 * number * number - 4);
        }
    }
}
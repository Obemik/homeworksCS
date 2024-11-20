namespace ClassApp
{
    internal static class UserInput
    {
        public static bool GetSortDirection()
        {
            Console.WriteLine("Оберіть напрямок сортування:");
            Console.WriteLine("1 - За зростанням");
            Console.WriteLine("2 - За зменшенням");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                return true;
            }
            else if (choice == "2")
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Невідомий вибір! Виберіть 1 або 2.");
            }
        }
    }
}
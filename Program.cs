using System;
using System.Text;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                int[] array = { 5, 2, 9, 1, 5, 6 };

                bool sortAscending = UserInput.GetSortDirection();

                SortHelper.SortArray(array, sortAscending);

                Console.WriteLine("Відсортований масив:");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }
        }
    }
}
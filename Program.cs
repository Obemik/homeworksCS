using ClassApp.Entities;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть кількість рядків матриці:");
                int rows = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть кількість стовпців матриці:");
                int columns = int.Parse(Console.ReadLine());

                Matrix matrix = new Matrix(rows, columns);

                Console.WriteLine("Як заповнити матрицю?");
                Console.WriteLine("1 - Випадкові числа");
                Console.WriteLine("2 - Ввести вручну");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Введіть мінімальне значення:");
                    int minValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введіть максимальне значення:");
                    int maxValue = int.Parse(Console.ReadLine());

                    matrix.InputDataRandom(minValue, maxValue);
                }
                else if (choice == 2)
                {
                    matrix.InputData();
                }
                else
                {
                    Console.WriteLine("Неправильний вибір.");
                    return;
                }

                Console.WriteLine("\nМатриця:");
                matrix.DisplayMatrix();

                Console.WriteLine($"\nМінімальний елемент: {matrix.GetMinimum()}");
                Console.WriteLine($"Максимальний елемент: {matrix.GetMaximum()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
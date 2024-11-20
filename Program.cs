using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int rows = 5;
            int cols = 5;
            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(-100, 101); 
                }
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int min = arr[0, 0];
            int max = arr[0, 0];
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"Min value: {min} at ({minRow}, {minCol})");
            Console.WriteLine($"Max value: {max} at ({maxRow}, {maxCol})");

            int sum = 0;
            int startRow = Math.Min(minRow, maxRow);
            int startCol = Math.Min(minCol, maxCol);
            int endRow = Math.Max(minRow, maxRow);
            int endCol = Math.Max(minCol, maxCol);

            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine($"Sum of elements between min and max: {sum}");
        }
    }
}
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Console.Write("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }

            double[,] B = new double[3, 4];

            Console.WriteLine("\nMatrix B (3x4):");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * (upperMaxRandomBound - lowerMaxRandomBound) + lowerMaxRandomBound;
                    Console.Write($"{B[i, j]:F2} "); 
                }
                Console.WriteLine();
            }

            int[] A = new int[5];
            Console.WriteLine("\nEnter 5 elements for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray A:");
            foreach (var value in A)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            double max = double.MinValue;
            double min = double.MaxValue;
            double totalSum = 0;
            double totalProduct = 1;

            foreach (int value in A)
            {
                if (value > max) max = value;
                if (value < min) min = value;
                totalSum += value;
                totalProduct *= value;
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double value = B[i, j];
                    if (value > max) max = value;
                    if (value < min) min = value;
                    totalSum += value;
                    totalProduct *= value;
                }
            }

            int sumEvenA = 0;
            foreach (int value in A)
            {
                if (value % 2 == 0) sumEvenA += value;
            }

            double sumOddColumnsB = 0;
            for (int j = 1; j < B.GetLength(1); j += 2)
            {
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    sumOddColumnsB += B[i, j];
                }
            }

            Console.WriteLine($"\nMaximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Total sum: {totalSum}");
            Console.WriteLine($"Total product: {totalProduct}");
            Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
            Console.WriteLine($"Sum of elements in odd columns of matrix B: {sumOddColumnsB}");
        }
    }
}
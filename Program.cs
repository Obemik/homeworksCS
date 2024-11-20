using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void MultiplyMatrixByScalar(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] *= scalar;
                }
            }
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new Exception("The matrices cannot be multiplied. The number of columns of the first matrix must be equal to the number of rows of the second matrix.");
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

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

            Console.Write("Enter the size of the array (N x N): ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                }
            }

            Console.WriteLine("\nThe original matrix is:");
            PrintMatrix(matrix);

            Console.Write("\nEnter a scalar to multiply the matrix: ");
            int scalar = Convert.ToInt32(Console.ReadLine());
            MultiplyMatrixByScalar(matrix, scalar);
            Console.WriteLine($"\nMatrix after multiplying by {scalar}:");
            PrintMatrix(matrix);

            int[,] matrix2 = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix2[i, j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                }
            }

            Console.WriteLine("\nThe second matrix is:");
            PrintMatrix(matrix2);

            if (matrix.GetLength(0) == matrix2.GetLength(0) && matrix.GetLength(1) == matrix2.GetLength(1))
            {
                int[,] sumMatrix = AddMatrices(matrix, matrix2);
                Console.WriteLine("\nSum of the matrices:");
                PrintMatrix(sumMatrix);
            }
            else
            {
                Console.WriteLine("\nThe matrices cannot be added as their dimensions do not match.");
            }

            if (matrix.GetLength(1) == matrix2.GetLength(0))
            {
                int[,] productMatrix = MultiplyMatrices(matrix, matrix2);
                Console.WriteLine("\nProduct of the matrices:");
                PrintMatrix(productMatrix);
            }
            else
            {
                Console.WriteLine("\nThe matrices cannot be multiplied as the number of columns of the first matrix does not match the number of rows of the second matrix.");
            }
        }
    }
}
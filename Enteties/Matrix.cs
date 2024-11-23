namespace ClassApp.Entities
{
    internal class Matrix
    {
        private int[,] data;
        private int rows;
        private int columns;

        public Matrix()
        {
            rows = 0;
            columns = 0;
            data = new int[0, 0];
        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }

        public Matrix(int[,] array)
        {
            rows = array.GetLength(0);
            columns = array.GetLength(1);
            data = array;
        }

        public void InputData()
        {
            Console.WriteLine("Введіть елементи матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Елемент [{i},{j}]: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void InputDataRandom(int minValue, int maxValue)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Матриця:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public int GetMinimum()
        {
            int min = data[0, 0];
            foreach (int value in data)
            {
                if (value < min)
                    min = value;
            }
            return min;
        }

        public int GetMaximum()
        {
            int max = data[0, 0];
            foreach (int value in data)
            {
                if (value > max)
                    max = value;
            }
            return max;
        }
    }
}
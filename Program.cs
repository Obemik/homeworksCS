using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter three numbers to search for:");
        int[] sequence = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Number {i + 1}: ");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        for (int i = 0; i <= size - 3; i++)
        {
            if (array[i] == sequence[0] && array[i + 1] == sequence[1] && array[i + 2] == sequence[2])
            {
                count++;
            }
        }

        Console.WriteLine($"\nThe sequence [{sequence[0]}, {sequence[1]}, {sequence[2]}] appears {count} times in the array.");
    }
}
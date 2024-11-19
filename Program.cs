using System;
using System.Linq;

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

        Console.Write("Enter the threshold value: ");
        int threshold = int.Parse(Console.ReadLine());

        int count = array.Count(x => x < threshold);

        Console.WriteLine($"\nNumber of values less than {threshold}: {count}");
    }
}
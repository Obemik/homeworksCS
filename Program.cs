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

        int evenCount = array.Count(x => x % 2 == 0);
        int oddCount = array.Count(x => x % 2 != 0);
        int uniqueCount = array.Distinct().Count();

        Console.WriteLine("\nResults:");
        Console.WriteLine($"Even numbers: {evenCount}");
        Console.WriteLine($"Odd numbers: {oddCount}");
        Console.WriteLine($"Unique elements: {uniqueCount}");
    }
}
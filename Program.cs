using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the source string: ");
        string source = Console.ReadLine();

        Console.Write("Enter the substring to search: ");
        string substring = Console.ReadLine();

        int count = 0;
        int startIndex = 0;

        while ((startIndex = source.IndexOf(substring, startIndex, StringComparison.Ordinal)) != -1)
        {
            count++;
            startIndex += substring.Length; 
        }

        Console.WriteLine($"The substring \"{substring}\" occurs {count} times in the source string.");
    }
}

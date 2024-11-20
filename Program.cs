using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };

        int vowelCount = 0;
        foreach (char c in sentence)
        {
            if (Array.Exists(vowels, v => v == c))
            {
                vowelCount++;
            }
        }

        Console.WriteLine($"The sentence contains {vowelCount} vowels.");
    }
}
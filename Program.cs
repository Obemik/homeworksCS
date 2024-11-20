using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int wordCount = 0;
        if (!string.IsNullOrWhiteSpace(sentence)) 
        {
            string[] words = sentence.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            wordCount = words.Length;
        }

        Console.WriteLine($"The sentence contains {wordCount} words.");
    }
}
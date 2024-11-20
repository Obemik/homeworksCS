using System;

namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string inputText = Console.ReadLine();

            Console.WriteLine("Enter the inappropriate word:");
            string inappropriateWord = Console.ReadLine();

            int replacements = 0;

            string resultText = ReplaceInappropriateWord(inputText, inappropriateWord, ref replacements);

            Console.WriteLine("\nModified text:");
            Console.WriteLine(resultText);
            Console.WriteLine($"\nStatistics: {replacements} replacement(s) of the word '{inappropriateWord}'");
        }

        static string ReplaceInappropriateWord(string text, string word, ref int replacementCount)
        {
            string modifiedText = text;
            while (modifiedText.Contains(word))
            {
                modifiedText = modifiedText.Replace(word, new string('*', word.Length));
                replacementCount++; 
            }

            return modifiedText;
        }
    }
}
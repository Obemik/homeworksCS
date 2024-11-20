using System;

namespace SentenceCapitalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string input = Console.ReadLine();

            string result = CapitalizeFirstLetterOfEachSentence(input);

            Console.WriteLine("Modified text:");
            Console.WriteLine(result);
        }

        static string CapitalizeFirstLetterOfEachSentence(string text)
        {
            bool newSentence = true;
            char[] chars = text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (newSentence && char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]); 
                    newSentence = false;
                }
                else if (chars[i] == '.' || chars[i] == '!' || chars[i] == '?')
                {
                    newSentence = true; 
                }
            }

            return new string(chars);
        }
    }
}
using System;

namespace CaesarCipher
{
    class Program
    {
        static string Encrypt(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char d = char.IsUpper(letter) ? 'A' : 'a'; 
                    buffer[i] = (char)((((letter + shift) - d) % 26 + 26) % 26 + d); 
                }
            }
            return new string(buffer);
        }

        static string Decrypt(string input, int shift)
        {
            return Encrypt(input, -shift); 
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the text to encrypt: ");
            string text = Console.ReadLine();

            Console.Write("Enter the shift (number): ");
            int shift = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(text, shift);
            Console.WriteLine($"Encrypted text: {encryptedText}");

            string decryptedText = Decrypt(encryptedText, shift);
            Console.WriteLine($"Decrypted text: {decryptedText}");
        }
    }
}
using System;
using System.Text;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                int number = 8; 
                bool isFibonacci = NumberCheck.IsFibonacci(number);

                Console.WriteLine($"Чи є число {number} числом Фібоначчі? {isFibonacci}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }
        }
    }
}
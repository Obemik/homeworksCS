//using System;
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            Console.Write("Введіть число від 1 до 100: ");
//            string input1 = Console.ReadLine();

//            if (int.TryParse(input1, out int A))
//            {
//                if (A >= 1 && A <= 100)
//                {
//                    if (A % 3 == 0 && A % 5 == 0)
//                    {
//                        Console.WriteLine("Fizz Buzz");
//                    }
//                    else if (A % 5 == 0)
//                    {
//                        Console.WriteLine("Buzz");
//                    }
//                    else if (A % 3 == 0)
//                    {
//                        Console.WriteLine("Fizz");
//                    }
//                    else
//                    {
//                        Console.WriteLine(A);
//                    }
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введіть коректні числа");
//            }
//        }
//    }
//}

//using System;
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            Console.Write("Введіть число: ");
//            string input1 = Console.ReadLine();
//            Console.Write("Введіть відсоток: ");
//            string input2 = Console.ReadLine();

//            if (int.TryParse(input1, out int A) && int.TryParse(input2, out int B))
//            {
//                double result = (A / 100.0) * B;
//                Console.WriteLine($"Результат: {result}");
//            }
//            else
//            {
//                Console.WriteLine("Введіть коректні числа");
//            }
//        }
//    }
//}

//using System;
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            int[] numbers = new int[4];
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.Write($"Введіть цифру {i + 1}: ");

//                if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
//                {
//                    numbers[i] = digit;
//                }
//                else
//                {
//                    Console.WriteLine("Будь ласка, введіть одну цифру від 0 до 9.");
//                    i--;
//                }
//            }

//            string result = string.Join("", numbers);
//            int finalNumber = int.Parse(result);

//            Console.WriteLine($"Сформоване число: {finalNumber}");
//        }
//    }
//}

//using System;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;
//        Console.Write("Введіть шестизначне число: ");
//        string input = Console.ReadLine();

//        if (input.Length != 6 || !int.TryParse(input, out int number))
//        {
//            Console.WriteLine("Помилка: введене число не є шестизначним.");
//            return;
//        }

//        Console.Write("Введіть номер першого розряду для заміни (1-6): ");
//        int pos1 = int.Parse(Console.ReadLine());

//        Console.Write("Введіть номер другого розряду для заміни (1-6): ");
//        int pos2 = int.Parse(Console.ReadLine());

//        if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
//        {
//            Console.WriteLine("Помилка: номери розрядів повинні бути в межах від 1 до 6.");
//            return;
//        }

//        char[] digits = input.ToCharArray();

//        pos1 -= 1;
//        pos2 -= 1;

//        char temp = digits[pos1];
//        digits[pos1] = digits[pos2];
//        digits[pos2] = temp;

//        string result = new string(digits);

//        Console.WriteLine($"Результат: {result}");
//    }
//}

//using System;
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            Console.Write("Введіть дату (dd.MM.yyyy): ");
//            string inputDate = Console.ReadLine();

//            string[] formats = { "d.MM.yyyy", "dd.MM.yyyy", "d.M.yyyy", "dd.M.yyyy" };

//            if (DateTime.TryParseExact(inputDate, formats, null, System.Globalization.DateTimeStyles.None, out DateTime date))
//            {
//                string season = GetSeason(date.Month);
//                string dayOfWeek = date.DayOfWeek.ToString();
//                Console.WriteLine($"{season} {dayOfWeek}");
//            }
//            else
//            {
//                Console.WriteLine("Невірний формат дати. Використовуйте формат dd.MM.yyyy.");
//            }
//        }

//        static string GetSeason(int month)
//        {
//            if (month == 12 || month <= 2)
//                return "Winter";
//            if (month >= 3 && month <= 5)
//                return "Spring";
//            if (month >= 6 && month <= 8)
//                return "Summer";
//            return "Autumn";
//        }
//    }
//}

//using System;
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;

//            Console.WriteLine("Виберіть конвертацію:");
//            Console.WriteLine("1 - Фаренгейт в Цельсій");
//            Console.WriteLine("2 - Цельсій в Фаренгейт");
//            Console.Write("Ваш вибір: ");
//            string choice = Console.ReadLine();

//            if (choice == "1" || choice == "2")
//            {
//                Console.Write("Введіть температуру: ");
//                string inputTemp = Console.ReadLine();

//                if (double.TryParse(inputTemp, out double temperature))
//                {
//                    if (choice == "1")
//                    {
//                        double celsius = (temperature - 32) * 5 / 9;
//                        Console.WriteLine($"{temperature}°F = {celsius:F2}°C");
//                    }
//                    else if (choice == "2")
//                    {
//                        double fahrenheit = (temperature * 9 / 5) + 32;
//                        Console.WriteLine($"{temperature}°C = {fahrenheit:F2}°F");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Невірне значення температури.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Невірний вибір.");
//            }
//        }
//    }
//}

using System;
using System.Text;

namespace homeworksCS
{
    internal class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть перше число: ");
            string input1 = Console.ReadLine();
            Console.Write("Введіть друге число: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("Парні числа у вказаному діапазоні:");

            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
            {
                if (num1 > num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                for (int i = num1; i <= num2; i++)
                {
                    if ((i % 2) == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Введіть коректні числа");
            }
        }
    }
}
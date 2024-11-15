//using System.Text;
//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("It's easy to win forgiveness for being wrong;\r\nbeing right is what gets you into real trouble.\r\nBjarne Stroustrup");
//        }
//    }
//}
//using System.Text;

//namespace homeworksCS
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.InputEncoding = Encoding.Unicode;
//            Console.OutputEncoding = Encoding.Unicode;
//            int[] numbers = new int[5];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.Write($"Введіть число {i + 1}: ");
//                numbers[i] = int.Parse(Console.ReadLine());
//            }
//            int sum = 0;
//            foreach (int num in numbers) { 
//                sum += num;
//            }
//            int product = 1;
//            foreach (int num in numbers) { 
//                product *= num;
//            }
//            int max = numbers[0];
//            int min = numbers[0];
//            foreach (int num in numbers)
//            {
//                if (num > max)
//                {
//                    max = num;
//                }
//                if (num < min)
//                {
//                    min = num;
//                }
//            }
//            Console.WriteLine($"Сума чисел: {sum}\nДобуток чисел: {product}\nНайменше число: {min}\nНайбільше число: {max}");
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

//            Console.Write("Введіть шестизначне число: ");
//            string input = Console.ReadLine();

//            if (input.Length == 6 && int.TryParse(input, out int number))
//            {
//                int reversedNumber = 0;

//                while (number > 0)
//                {
//                    int lastDigit = number % 10;
//                    reversedNumber = reversedNumber * 10 + lastDigit;
//                    number /= 10;
//                }

//                Console.WriteLine($"Перевернуте число: {reversedNumber}");
//            }
//            else
//            {
//                Console.WriteLine("Введіть коректне шестизначне число");
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

//            Console.Write("Введіть перше число: ");
//            string input1 = Console.ReadLine();
//            Console.Write("Введіть друге число: ");
//            string input2 = Console.ReadLine();

//            int a = 0, b = 1;

//            Console.WriteLine("Числа Фібоначчі в заданому діапазоні:");

//            if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
//            {
//                if (num1 > num2)
//                {
//                    int temp = num1;
//                    num1 = num2;
//                    num2 = temp;
//                }

//                while (a <= num2)
//                {
//                    if (a >= num1)
//                    {
//                        Console.Write(a + " ");
//                    }

//                    int next = a + b;
//                    a = b;
//                    b = next;
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

//            Console.Write("Введіть перше число: ");
//            string input1 = Console.ReadLine();
//            Console.Write("Введіть друге число: ");
//            string input2 = Console.ReadLine();

//            if (int.TryParse(input1, out int A) && int.TryParse(input2, out int B))
//            {
//                if (A > B)
//                {
//                    int temp = A;
//                    A = B;
//                    B = temp;
//                }

//                for (int i = A; i <= B; i++)
//                {
//                    for (int j = 1; j <= i; j++)
//                    {
//                        Console.Write(i + " ");
//                    }
//                    Console.WriteLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введіть коректні числа");
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

            Console.Write("Введіть довжину лінії: ");
            string input1 = Console.ReadLine();
            Console.Write("Введіть символ заповнювач: ");
            string input2 = Console.ReadLine();
            Console.Write("Введіть напрямок лінії (горизонтальна, вертикальна): ");
            string input3 = Console.ReadLine();

            if (int.TryParse(input1, out int A) && int.TryParse(input2, out int B))
            {
                if (A > B)
                {
                    int temp = A;
                    A = B;
                    B = temp;
                }

                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Введіть коректні числа");
            }
        }
    }
}
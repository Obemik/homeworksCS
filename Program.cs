using System;

namespace ArithmeticExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression with + and - operators:");
            string input = Console.ReadLine();

            input = input.Replace(" ", "");

            int result = 0;
            int currentNumber = 0;
            char currentOperator = '+';

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    currentNumber = currentNumber * 10 + (currentChar - '0'); 
                }

                if (i == input.Length - 1 || currentChar == '+' || currentChar == '-')
                {
                    if (currentOperator == '+')
                    {
                        result += currentNumber; 
                    }
                    else if (currentOperator == '-')
                    {
                        result -= currentNumber; 
                    }

                    if (currentChar == '+' || currentChar == '-')
                    {
                        currentOperator = currentChar; 
                    }

                    currentNumber = 0; 
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
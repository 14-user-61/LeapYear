using System;

namespace Task4_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть вираз: ");
            string input = Console.ReadLine();

            double[] numbers = new double[100];
            char[] operators = new char[100];
            int numCount = 0;
            int opCount = 0;
            string currentNumber = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == ' ')
                {
                    continue;
                }

                if ((c >= '0' && c <= '9') || c == ',' || c == '.')
                {
                    if (c == '.')
                    {
                        c = ',';
                    }
                    currentNumber = currentNumber + c;
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    numbers[numCount] = Convert.ToDouble(currentNumber);
                    numCount++;

                    operators[opCount] = c;
                    opCount++;

                    currentNumber = "";
                }
            }
            numbers[numCount] = Convert.ToDouble(currentNumber);
            numCount++;

            for (int i = 0; i < opCount; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    if (operators[i] == '*')
                    {
                        numbers[i] = numbers[i] * numbers[i + 1];
                    }
                    else
                    {
                        numbers[i] = numbers[i] / numbers[i + 1];
                    }
                    for (int j = i + 1; j < numCount - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    numCount--;

                    for (int j = i; j < opCount - 1; j++)
                    {
                        operators[j] = operators[j + 1];
                    }
                    opCount--;

                    i--;
                }
            }
            double result = numbers[0];
            for (int i = 0; i < opCount; i++)
            {
                if (operators[i] == '+')
                {
                    result = result + numbers[i + 1];
                }
                else if (operators[i] == '-')
                {
                    result = result - numbers[i + 1];
                }
            }
            Console.WriteLine($"Відповідь програми: {result}");
        }
    }
}

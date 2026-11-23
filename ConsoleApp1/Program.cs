using System;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть рік: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"Рік {year} є високосним.");
            }
            else
            {
                Console.WriteLine($"Рік {year} НЕ є високосним.");
            }

            Console.ReadKey();
        }
    }
}


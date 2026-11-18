using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Вкажіть рік");
            int year = int.Parse(Console.ReadLine());

                if (year % 400 == 0)
                {
                    Console.WriteLine($" {year} Рік високосний");
                }
                else if (year % 100 == 0)
                {
                    Console.WriteLine($" {year} Рік не високосний");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine($"{year} Високосний ");
                }
            else
            {
                Console.WriteLine($"{year} Рік не високосний"); 
            }
        }
    }
}

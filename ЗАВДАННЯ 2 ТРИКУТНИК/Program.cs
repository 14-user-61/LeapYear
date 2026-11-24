using System;

namespace TASK_2_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть висоту трикутника: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

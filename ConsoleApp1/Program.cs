using System;

namespace MillionaireGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int score = 0;

            string[] questions = new string[]
            {
                "Питання 1, які кольори у прапора України?",
                "Питання 2, в якому місті знаходиться ДТЕУ?",
                "Питання 3, яка страва є головною національною стравою України, внесеною до списку спадщини ЮНЕСКО?",
                "Питання 4, скільки біт в одному байті?",
                "Питання 5, який оператор у C# використовується для перевірки умови?"
            };

            string[] options1 = { "1. жовтий і блакитний", "2. червоний і зелений", "3. чорний і жовтий", "4. зелений і фіолетовий" };
            string[] options2 = { "1. Вінниця", "2. Київ", "3. Львів", "4. Одеса" };
            string[] options3 = { "1. Паста", "2. Суші", "3. Борщ", "4. Піца" };
            string[] options4 = { "1. 4 біти", "2. 8 біт", "3. 16 біт", "4. 32 біти" };
            string[] options5 = { "1. for", "2. while", "3. if", "4. switch" };

            string[][] allOptions = new string[][] { options1, options2, options3, options4, options5 };

            int[] correctAnswers = { 1, 2, 3, 2, 3 };

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Current User Score: {score}");
                Console.WriteLine(questions[i]);

                foreach (string option in allOptions[i])
                {
                    Console.WriteLine("\t" + option);
                }

                Console.Write("Ваша відповідь: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == correctAnswers[i])
                {
                    Console.WriteLine("Correct answer\n");
                    score += 100;
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    break;
                }
            }

            Console.WriteLine("кінець програми.");
            Console.ReadKey();
        }
    }
}


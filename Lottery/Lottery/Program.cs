using System;
using System.Collections.Generic;

namespace Lottery
{
    class Program
    {
        static List<int> GetRandomNumbers()
        {
            Random rnd = new Random();
            List<int> random_numbers = new List<int>(new int[5]);
            for (int i = 0; i < 5; i++)
            {
                random_numbers[i] = rnd.Next(1, 90);
            }
            return random_numbers;
        }


        static List<int> TakeInput()
        {
            List<int> user_numbers = new List<int>(new int[5]);
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Add meg az {i + 1}. számot: ");
                user_numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return user_numbers;
        }


        static void Main()
        {
            List<int> user_numbers = TakeInput();
            int total = new int();
            while (true)
            {
                List<int> random_numbers = GetRandomNumbers();
                int counter = new int();
                for (int i = 0; i < 5; i++)
                {
                    if (random_numbers.Contains(user_numbers[i]))
                    {
                        counter++;
                        total++;
                    }
                }
                if (counter == 5)
                {
                    Console.WriteLine("Nyertél!");
                    Console.Write("Kihúzott számok: ");
                    random_numbers.ForEach(Console.Write);
                    Console.WriteLine($"\n{total} Szelvényből.");
                    break;
                }
            }
        }
    }
}

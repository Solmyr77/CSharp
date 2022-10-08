using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static int total = 0;
        static bool complete_flag = false;
        static int current_random_number;
        static HashSet<int> random_numbers = new HashSet<int>();
        static HashSet<int> user_numbers = new HashSet<int>();
        static Random rnd = new Random();
        static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int current_number;

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Add meg a(z) {i + 1}. számot: ");
                            current_number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nAdj meg egy számot!\n");
                        }
                    }

                    if (current_number < 1 || current_number > 90)
                    {
                        Console.WriteLine("\n1 és 90 között adj meg egy számot!\n");
                        continue;
                    }

                    if (!user_numbers.Contains(current_number))
                    {
                        user_numbers.Add(current_number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ezt a számot már megadtad, válassz másikat.");
                    }
                }
            }



            sw.Start();

            Thread t1 = new Thread(new ThreadStart(main_task));
            Thread t2 = new Thread(new ThreadStart(main_task));
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            TimeSpan time_taken = sw.Elapsed;

            Console.WriteLine($"\nPörgetések száma: {total}\n");
            Console.WriteLine($"A program {time_taken.ToString(@"s\.ff")} mp alatt futott le.\n");
            Console.Write("A számaid:");

            foreach (int num in user_numbers)
            {
                Console.Write($" {num}");
            }

            Console.Write("\nA húzott számok:");

            foreach (int num in random_numbers)
            {
                Console.Write($" {num}");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nNyomj meg egy gombot a kilépéshez . . .");
            Console.ReadKey();
        }

        static void main_task()
        {
            while (complete_flag == false)
            {
                total++;
                random_numbers.Clear();
                for (int i = 0; i < 5; i++)
                {
                    while (true)
                    {
                        current_random_number = rnd.Next(1, 91);
                        if (!random_numbers.Contains(current_random_number))
                        {
                            random_numbers.Add(current_random_number);
                            break;
                        }
                    }
                }

                if (user_numbers.SetEquals(random_numbers))
                {
                    complete_flag = true;
                    sw.Stop();
                }
            }
        }
    }
}
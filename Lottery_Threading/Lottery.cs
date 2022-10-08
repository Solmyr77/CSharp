using System;
using System.Threading;
using System.Diagnostics;
using System.Collections;

namespace Course
{
    internal class Lottery
    {
        Random rnd = new Random();
        HashSet<int> randomNumbers = new HashSet<int>();
        int currentRandomNumber;

        static HashSet<int> finalRandomNumbers = new HashSet<int>();
        static HashSet<int> userNumbers = new HashSet<int>();
        static Stopwatch sw = new Stopwatch();
        static int total = 0;
        static bool completeFlag = false;

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

                    if (!userNumbers.Contains(current_number))
                    {
                        userNumbers.Add(current_number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ezt a számot már megadtad, válassz másikat.");
                    }
                }
            }

            int processors = 1;
            string processorsStr = System.Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
            if (processorsStr != null)
            {
                processors = int.Parse(processorsStr);
            }

            Thread[] threads = new Thread[processors];

            for (int i = 0; i < processors; i++)
            {
                threads[i] = new Thread(new ThreadStart(MainTask));
            }

            sw.Start();

            for (int i = 0; i < processors; i++)
            {
                threads[i].Start();
            }
            for (int i = 0; i < processors; i++)
            {
                threads[i].Join();
            }

            TimeSpan timeTaken = sw.Elapsed;

            Console.WriteLine($"\nPörgetések száma: {total}\n");
            Console.WriteLine($"A program {timeTaken.ToString(@"s\.ff")} mp alatt futott le.\n");
            Console.Write("A számaid:");

            foreach (int num in userNumbers)
            {
                Console.Write($" {num}");
            }

            Console.Write("\nA húzott számok:");

            foreach (int num in finalRandomNumbers)
            {
                Console.Write($" {num}");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nNyomj meg egy gombot a kilépéshez . . .");
            Console.ReadKey();
        }

        static void MainTask()
        {
            Lottery pg = new Lottery();

            while (!completeFlag)
            {
                total++;
                pg.randomNumbers.Clear();
                for (int i = 0; i < 5; i++)
                {
                    while (true)
                    {
                        pg.currentRandomNumber = pg.rnd.Next(1, 91);
                        if (!pg.randomNumbers.Contains(pg.currentRandomNumber))
                        {
                            pg.randomNumbers.Add(pg.currentRandomNumber);
                            break;
                        }
                    }
                }

                if (userNumbers.SetEquals(pg.randomNumbers))
                {
                    finalRandomNumbers = pg.randomNumbers;
                    completeFlag = true;
                    sw.Stop();
                }
            }
        }
    }
}
using System.Linq;
using System;
using System.Drawing;

namespace Groups
{
    internal class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int numberOfPlayers = 0;
            while (true)
            {
                try
                {
                    Console.Write("Add meg hány játékos van: ");
                    numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat.");
                }
            }

            int numberOfGroups = 0;
            while (true)
            {
                try
                {
                    Console.Write("Add meg hány csoportot szeretnél: ");
                    numberOfGroups = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Hibás adat.");
                }
            }


            List<string> players = new List<string>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Add meg a(z) {i + 1}. játékos nevét: ");
                        string currPlayer = Console.ReadLine() ?? throw new ArgumentNullException();
                        if (currPlayer == "")
                        {
                            Console.WriteLine("Adj meg egy nevet!");
                            continue;
                        }

                        if (players.Contains(currPlayer))
                        {
                            Console.WriteLine("Ez a játékos már szerepel a listában!");
                        }
                        else
                        {
                            players.Add(currPlayer);
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Hibás adat.");
                    }
                }
            }

            string[] shuffledPlayers = new string[players.Count]; shuffledPlayers = players.OrderBy(a => rnd.Next()).ToArray();

            int chunkSize = shuffledPlayers.Length / numberOfGroups;
            if (shuffledPlayers.Length % numberOfGroups != 0)
            {
                chunkSize++;
            }

            int sIndex = 0;
            string[][] groups = shuffledPlayers.GroupBy(s => sIndex++ / chunkSize).Select(s => s.ToArray()).ToArray();

            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Csoport {i + 1}:");
                for (int j = 0; j < groups[i].Length; j++)
                {
                    Console.WriteLine(groups[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
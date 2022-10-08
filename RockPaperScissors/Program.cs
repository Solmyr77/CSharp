using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userPoints = 0;
            int opponentPoints = 0;
            int randomPick;

            Random rnd = new Random();

            do
            {
                string userPick;

                while (true)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Rock, paper, scissors?: ");
                        userPick = Console.ReadLine().ToLower();

                        if (!(userPick == "rock" || userPick == "paper" || userPick == "scissors"))
                        {
                            Console.WriteLine("Wrong input.");
                            continue;
                        }

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Something went wrong.");
                    }
                }

                randomPick = rnd.Next(0, 3);
                // rock = 0, paper = 1, scissors = 2

                switch (userPick)
                {
                    case "rock":
                        Rock rockObject = new Rock(randomPick);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n{rockObject.AnnouncePick()}\n");
                        Console.WriteLine(rockObject.Test());
                        Console.ForegroundColor = ConsoleColor.White;

                        int[] rockPoints = rockObject.AwardPoints(rockObject.Flag);
                        userPoints += rockPoints[0];
                        opponentPoints += rockPoints[1];

                        Console.WriteLine($"You have {userPoints} points, your opponent has {opponentPoints} points.");
                        break;

                    case "paper":
                        Paper paperObject = new Paper(randomPick);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n{paperObject.AnnouncePick()}\n");
                        Console.WriteLine(paperObject.Test());
                        Console.ForegroundColor = ConsoleColor.White;

                        int[] paperPoints = paperObject.AwardPoints(paperObject.Flag);
                        userPoints += paperPoints[0];
                        opponentPoints += paperPoints[1];

                        Console.WriteLine($"You have {userPoints} points, your opponent has {opponentPoints} points.");
                        break;

                    case "scissors":
                        Scissors scissorsObject = new Scissors(randomPick);

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n{scissorsObject.AnnouncePick()}\n");
                        Console.WriteLine(scissorsObject.Test());
                        Console.ForegroundColor = ConsoleColor.White;

                        int[] scissorsPoints = scissorsObject.AwardPoints(scissorsObject.Flag);
                        userPoints += scissorsPoints[0];
                        opponentPoints += scissorsPoints[1];

                        Console.WriteLine($"You have {userPoints} points, your opponent has {opponentPoints} points.");
                        break;
                }
            }
            while (opponentPoints != 3 && userPoints != 3);

            if (userPoints == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nCongratulations, you won!\n\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n\nYou lost, better luck next time!\n\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to escape...");
            Console.ReadKey();
        }
    }
}
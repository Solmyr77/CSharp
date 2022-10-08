using StudentDataGen;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenDataGen
{
    class Program
    {
        static void Main()
        {
            string appdataLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            int studentNumber;

            while (true)
            {
                try
                {
                    Console.Write("How many students to generate: ");
                    studentNumber = Convert.ToInt32(Console.ReadLine() ?? throw new ArgumentException());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            File.WriteAllText("students.txt", "");
            File.AppendAllText("students.txt", "Firstname,Lastname,Age,Average\n");

            string[] firstnames = File.ReadAllLines($"{appdataLocation}/StudentDataGen/firstnames.txt");
            string[] lastnames = File.ReadAllLines($"{appdataLocation}/StudentDataGen/lastnames.txt");

            Student[] students = new Student[studentNumber];

            for (int i = 0; i < studentNumber; i++)
            {
                Random rnd = new Random();

                string currFirstname = firstnames[rnd.Next(0, firstnames.Length + 1)];
                string currLastname = lastnames[rnd.Next(0, lastnames.Length + 1)];

                int currAge = rnd.Next(14, 22);

                double currAverage = Math.Round(rnd.NextDouble() * (5 - 1.5) + 1.5, 2);

                students[i] = new Student(currFirstname, currLastname, currAge, currAverage);

                File.AppendAllText("students.txt", students[i].GetData());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nSuccessfully generated {studentNumber} students.");
            Console.WriteLine("\nPress any key to exit...");

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
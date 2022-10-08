using System;
using System.IO;

namespace Allat
{
    public class AnimalSpecies
    {
        public string name;
        public int weight;

        public AnimalSpecies(string animal_name, int animal_weight)
        {
            name = animal_name;
            weight = animal_weight;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalSpecies[] allatok = new AnimalSpecies[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Add meg a(z) {i+1}. állat nevét: ");
                string current_name = Console.ReadLine();

                Console.Write($"Add meg a(z) {i + 1}. állat tömegét: ");
                int current_weight = Convert.ToInt32(Console.ReadLine());

                AnimalSpecies current_animal = new AnimalSpecies(current_name, current_weight);

                allatok[i] = current_animal;
            }

            AnimalSpecies highest_weight = allatok[0];

            for (int i = 0; i < 3; i++)
            {
                if (allatok[i].weight > highest_weight.weight)
                {
                    highest_weight = allatok[i];
                }
            }
            
            try
            {
                StreamWriter sw = new StreamWriter($"{Directory.GetCurrentDirectory()}\\output.txt");
                sw.WriteLine($"A legnehezebb állat a(z) {highest_weight.name}.");
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Hiba: {ex.Message}");
            }
        }
    }
}

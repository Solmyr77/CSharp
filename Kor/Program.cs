namespace Kor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Ember[] people = new Ember[3];

            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Adj meg egy nevet: ");

                        string currName = Console.ReadLine() ?? throw new ArgumentNullException();

                        if (currName == "")
                        {
                            throw new ArgumentException();
                        }

                        Console.Write($"Add meg {currName} születési évét: ");
                        int currBirthyear = Convert.ToInt32(Console.ReadLine());

                        people[i] = new Ember(currName, currBirthyear);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Hibás adat.");
                    }
                }
            }

            Ember oldest = people[0];

            for (int i = 0; i < 3; i++)
            {
                if (oldest.birthyear > people[i].birthyear)
                {
                    oldest = people[i];
                }

                Console.WriteLine($"{people[i].name} most {today.Year - people[i].birthyear} éves.");
            }

            File.WriteAllText("legidosebb.txt", $"{oldest.name} a legidősebb.");
        }
    }
}
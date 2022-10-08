List<int> user_numbers = new List<int>();
int user_input;

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        while (true)
        {
            try
            {
                Console.Write($"Add meg az {i + 1}. számot (1 és 99 között): ");
                user_input = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Hibás adat!");
            }
        }

        if (user_input < 1 || user_input > 99)
        {
            Console.WriteLine("1 és 99 között!");
            continue;
        }

        if (!user_numbers.Contains(user_input))
        {
            user_numbers.Add(user_input);
            break;
        }
        else
        {
            Console.WriteLine("Ezt a számot már megadtad, válassz másikat: ");
        }
    }
}

Random rand = new Random();
List<int> random_numbers = new List<int>();

int curr_num;
for (int i = 0; i < 5; i++)
{
    do
    {
        curr_num = rand.Next(1, 100);
    }
    while (random_numbers.Contains(curr_num));

    random_numbers.Add(curr_num);
}

int matches = 0;
for (int i = 0; i < 5; i++)
{
    if (user_numbers.Contains(random_numbers[i]))
    {
        matches++;
    }
}

Console.Write("\nA te számaid:");
foreach (int num in user_numbers)
{
    Console.Write($" {num},");
}
Console.WriteLine();
Console.Write("\nA generált számok:");
foreach (int num in random_numbers)
{
    Console.Write($" {num},");
}
Console.WriteLine($"\n\nTalálatok: {matches}");
int[] user_numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Add meg az {i + 1}. számot: ");
    user_numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int[] random_numbers = new int[5];
int total = 0;

while (true)
{
    total++;
    for (int i = 0; i < 5; i++)
    {
        Random rnd = new Random();
        int curr_rand = rnd.Next(91);
        bool inarray = false;

        for (int j = 0; j < 5; j++)
        {
            if (curr_rand == random_numbers[j])
            {
                inarray = true;
            }

            if (inarray == false)
            {
                random_numbers[i] = curr_rand;
            }
        }
    }

    int counter = 0;

    for (int i = 0; i < 5; i++)
    {
        int curr_num = user_numbers[i];
        bool inarray = false;

        for (int j = 0; j < 5; j++)
        {
            if (curr_num == random_numbers[j])
            {
                inarray = true;
            }

        }
        if (inarray == true)
        {
            counter++;
        }
    }

    if (counter == 5)
    {
        break;
    }
}

Console.Write("A te számaid:");
foreach (int num in user_numbers)
{
    Console.Write($" {num}");
}
Console.Write("\n");

Console.Write("A húzott számok:");
foreach (int num in random_numbers)
{
    Console.Write($" {num}");
}
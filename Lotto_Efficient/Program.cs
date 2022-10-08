int[] user_numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    while (true)
    {
        int current_num = 0;
        while (true)
        {
            try
            {
                Console.Write($"Add meg a {i + 1}. számot: ");
                current_num = Convert.ToInt32(Console.ReadLine());

                if (current_num < 1 || current_num > 90)
                {
                    Console.WriteLine("1 és 90 között.");
                    continue;
                }

                break;
            }
            catch
            {
                Console.WriteLine("Hibás adat.");
            }
        }

        bool inarray = false;
        for (int j = 0; j < 5; j++)
        {
            if (current_num == user_numbers[j])
            {
                inarray = true;
                break;
            }
        }

        if (!inarray)
        {
            user_numbers[i] = current_num;
            break;
        }

        else
        {
            Console.WriteLine("Ezt a számot már megadtad!");
        }
    }
}

Random rnd = new Random();

HashSet<int> current_numbers = new HashSet<int>(user_numbers);
HashSet<int> random_numbers = new HashSet<int>();

while (true)
{
    while (random_numbers.Count < 5)
    {
        var next = rnd.Next(1, 91);
        if (!current_numbers.Contains(next))
            random_numbers.Add(next);
    }

    bool hashset_match = current_numbers.SetEquals(random_numbers);

    if (hashset_match)
    {
        break;
    }
}
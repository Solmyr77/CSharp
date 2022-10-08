Random rnd = new Random();

//Take input
int[] user_numbers = new int[5];
for (int i = 0; i < 5; i++)
{
    while (true)
    {
        Console.Write($"Add meg a {i + 1}. számot: ");
        int current_num = Convert.ToInt32(Console.ReadLine());
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

//Compare arrays
int total = 0;
while (true)
{
    total++;

    int[] random_numbers = new int[5];

    for (int i = 0; i < 5; i++)
    {
        int current_num = rnd.Next();
        bool inarraya = false;

        for (int j = 0; j < 5; j++)
        {
            if (current_num == random_numbers[j])
            {
                inarraya = true;
                break;
            }
        }

        if (!inarraya)
        {
            random_numbers[i] = current_num;
        }
    }

    int inarray = 0;

    for (int i = 0; i < 5; i++)
    {

        int current_num = user_numbers[i];

        for (int j = 0; j < 5; j++)
        {
            if (current_num == random_numbers[j])
            {
                inarray++;
            }
        }
    }

    if (inarray == 5)
    {
        foreach (int num in user_numbers)
        {
            Console.WriteLine(num);
        }

        break;
    }
}

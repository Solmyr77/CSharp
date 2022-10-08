string testpass(int points, int bonus_points)
{
    if (bonus_points > 10 || (points * bonus_points) > 100)
    {
        return "MEGFELELT";
    }
    else
    {
        return "NEM FELELT MEG";
    }
}

while (true)
{
    Console.Write("Adja meg a nevet: ");
    string curr_name = Convert.ToString(Console.ReadLine());
    if (curr_name == "")
    {
        break;
    }

    Console.Write("Adja meg az elért pontot: ");
    int curr_points = Convert.ToInt32(Console.ReadLine());

    Console.Write("Adja meg az elért bónusz pontot: ");
    int curr_bonus_points = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{curr_name} tesztjének minősítése: {testpass(curr_points, curr_bonus_points)}");
}
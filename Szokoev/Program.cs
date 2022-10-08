Console.Write("Adja meg az első évszámot: ");
int year_min = Convert.ToInt32(Console.ReadLine());

Console.Write("Adja meg a második évszámot: ");
int year_max = Convert.ToInt32(Console.ReadLine());

int[] years = Enumerable.Range(year_min, year_max - year_min + 1).ToArray();

List<int> leap_years = new List<int>();

for (int i = 0; i < years.Length; i++)
{
    int curr_year = years[i];

    if (curr_year % 400 == 0 || (curr_year % 4 == 0 && curr_year % 100 != 0))
    {
        leap_years.Add(curr_year);
    }
}

if (leap_years.Count == 0)
{
    Console.WriteLine("Nincs szökőév a megadott tartományban.");
}

Console.Write("\nSzökőévek: ");
foreach (int year in leap_years)
{
    Console.Write($"{year}, ");
}
Console.WriteLine();
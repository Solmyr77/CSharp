public class Utas
{
    public int kedvezmeny;
    public int km;
    public int jegyar;

    public Utas(int akedvezmeny, int akm)
    {
        kedvezmeny = akedvezmeny;
        km = akm;

        Console.WriteLine(kedvezmeny);
        Console.WriteLine(km);

        this.jegyar = km * 50 * (1 - kedvezmeny / 100);
        Console.WriteLine(jegyar/km);
    }

    public double kmar()
    {
        return Convert.ToDouble(this.jegyar / this.km);
    }

    public string jegytipus()
    {
        if (kedvezmeny == 0)
        {
            return "Teljes";
        }

        else if (kedvezmeny == 50)
        {
            return "Diák";
        }

        else if (kedvezmeny == 90)
        {
            return "Nyugdíjas";
        }

        else
        {
            return "Egyéb";
        }
    }
}

public class App
{
    public static void Main(string[] args)
    {
        int counter = 0;
        List<Utas> utasok = new List<Utas>();

        while (counter <= 8)
        {
            Console.Write("Adja meg hány százalékos kedvezményt szeretne: ");
            int curr_kedvezmeny = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg hány kilómétert fog utazni: ");
            int curr_km = Convert.ToInt32(Console.ReadLine());

            if (curr_km == 0)
            {
                break;
            }
            else
            {
                counter++;
                Utas curr_utas = new Utas(curr_kedvezmeny, curr_km);
                utasok.Add(curr_utas);
            }
        }

        for (int i = 0; i < utasok.Count; i++)
        {
            Utas s_utas = utasok[i];
            Console.WriteLine($"{s_utas.jegytipus()}({s_utas.kedvezmeny}%), 1 kilométer ára: {s_utas.kmar()} Forint");
        }
    }
}
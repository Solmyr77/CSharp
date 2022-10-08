int counter = 0;

while (true)
{
    counter++;

    Console.Write("Írja be a testhőmérsékletet C-fokban! ");
    double curr_temp = Convert.ToDouble(Console.ReadLine());

    if (30 <= curr_temp && 42 >= curr_temp && counter <= 10)
    {
        if (curr_temp < 37)
        {
            Console.WriteLine("Normális testhőmérséklet.");
        }
        else if (curr_temp < 38)
        {
            Console.WriteLine("Hőemelkedés.");
        }
        else
        {
            Console.WriteLine("Láz");
        }
    }
    else
    {
        break;
    }
}
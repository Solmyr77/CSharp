double multiply(double num_1, double num_2)
{
    double val = num_1 * num_2;
    return val;
}

double divide(double num_1, double num_2)
{
    double val = num_2 / num_1;
    return val;
}

Console.WriteLine(Math.Round(divide(multiply(7.8, 2), 2)));
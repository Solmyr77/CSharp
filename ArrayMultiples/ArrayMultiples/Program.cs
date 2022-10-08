namespace ArrayMultiples
{
    internal class Program
    {
        static int[] ArrayOfMultiples(int num, int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = num;
                numbers[i] = numbers[i] * (i + 1);
            }
            return numbers;
        }

        static void Main()
        {
            foreach (var item in ArrayOfMultiples(7, 5))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
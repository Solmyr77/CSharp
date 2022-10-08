namespace Copilot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci sequence
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 0;
            while (i < 10)
            {
                c = a + b;
                a = b;
                b = c;
                i++;
                // print fibonacci sequence
                System.Console.WriteLine(c);
            }
        }
    }
}
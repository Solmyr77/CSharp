using System;
using System.Diagnostics;

namespace Primes
{
    class Program
    {

        
        static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }


        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            for (int i = 1; i < 100000000; i++)  //100 mil
            {
                IsPrime(i);
            }

            watch.Stop();

            Console.WriteLine($"Time: {watch.ElapsedMilliseconds} ms");
        }


    }
}

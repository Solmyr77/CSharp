namespace AsyncAwait
{
    internal class Program
    {
        async void AMethod()
        {
            await Task.Delay(1000);
            Console.WriteLine("Hello World!");
        }
        static void Main(string[] args)
        {
            var program = new Program();
            program.AMethod();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }
}
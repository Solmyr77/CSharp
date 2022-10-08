namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeatFlag;
            string selector;

            do
            {
                selector = GetInput("Write, read, clear?: ");

                switch (selector.ToLower())
                {
                    case "write":
                        Console.WriteLine(WriteToFileMethod(GetInput("Text to write into file: ")));
                        break;
                    case "read":
                        Console.WriteLine(ReadFromFileMethod());
                        break;
                    case "clear":
                        Console.WriteLine(ClearFileMethod());
                        break;
                }

                repeatFlag = GetInput("Select operation again (yes/no)?: ");
            }
            while (repeatFlag.ToLower() == "yes" || repeatFlag.ToLower() == "y");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static string GetInput(string text)
        {
            string currInput;

            while (true)
            {
                try
                {
                    Console.Write(text);
                    currInput = Console.ReadLine() ?? throw new ArgumentNullException();

                    if (currInput != "")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No input, try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("Input error!");
                }
            }
            return currInput;
        }

        static string WriteToFileMethod(string text)
        {
            try
            {
                File.WriteAllText("textfile.txt", text);
                return "Succesfully wrote to file.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return "Couldn't write to file.";
            }
        }

        static string ReadFromFileMethod()
        {
            try
            {
                return File.ReadAllText("textfile.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return "Couldn't read file.";
            }
        }

        static string ClearFileMethod()
        {
            try
            {
                File.WriteAllText("textfile.txt", null);
                return "Cleared File.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return "Couldn't clear file.";
            }
        }
    }
}
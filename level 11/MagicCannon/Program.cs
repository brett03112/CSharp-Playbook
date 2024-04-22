namespace MagicCannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We've got to warn the crew about the blasts from the canon.");

            for(int i = 1; i <=100;  i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                { 
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}:  Fire and Electric!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}:  Fire");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}:  Electric");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine($"{i}:  Normal");
                }
            }
        }
    }
}
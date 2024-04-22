namespace LoopsNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playersNumber = -1;
            while (playersNumber < 0 || playersNumber > 10)
            {
                Console.Write("Enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = int.Parse(playerResponse);
            }
            int x1 = 1;
            while (x1 <= 5)
            {
                Console.WriteLine(x1);
                x1++;
            }
            Console.Write('\n');
            for (int x = 1; x <= 5; x++)
                Console.WriteLine(x);

            while (true)
            {
                Console.Write("Think of a number and type it here: ");
                string input = Console.ReadLine();
                if (input == "quit" || input == "exit")
                    break;
                int number = int.Parse(input);
                if (number == 12)
                {
                    Console.WriteLine("I don't like that number. Pick another one.");
                    continue;
                }
                Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
            }
            for (int a = 1; a <= 10; a++)
                for (int b = 1; b <= 10; b++)
                    Console.WriteLine($"{a} * {b} = {a * b}");

            //  This code displays a grid of *’s based on the number of rows and columns dictated by
            //  totalRows and totalColumns.
            int totalRows = 5;
            int totalColumns = 10;
            for (int currentRow = 1; currentRow <= totalRows; currentRow++)
            {
                for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
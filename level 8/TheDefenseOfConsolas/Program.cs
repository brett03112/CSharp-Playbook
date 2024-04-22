namespace TheDefenseOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Construct a game in which targets are selected on a chess board and 4 defenders must protect the 
                area grid square of the target.  Cannot use row/column 1 or 8 as targets due to limitations.
            */

            Console.Title = "The Defense of Consolas";

            int targetRow = 0;
            int targetCol = 0;

            Console.WriteLine("Enter the target row:  ");
            targetRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the target column:  ");
            targetCol = int.Parse(Console.ReadLine());

            //Now figure out the defenders positions according to the target coordinates
            int defenderARow = targetRow + 1;
            int defenderACol = targetCol;

            int defenderBRow = targetRow - 1;
            int defenderBCol = targetCol;

            int defenderCRow = targetRow;
            int defenderCCol = targetCol - 1;

            int defenderDRow = targetRow;
            int defenderDCol = targetCol + 1;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine($"The target row and column is {targetRow},{targetCol}.");
            Console.WriteLine($"Defender A's location has moved to {defenderARow},{defenderACol}");
            Console.WriteLine($"Defender B's location has moved to {defenderBRow},{defenderBCol}");
            Console.WriteLine($"Defender C's location has moved to {defenderCRow},{defenderCCol}");
            Console.WriteLine($"Defender D's location has moved to {defenderDRow},{defenderDCol}");

            Console.Beep(440, 1500);
        }
    }
}
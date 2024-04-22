internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Use 'csharprepl' from the Powershell command line for test
        */
        Console.WriteLine("Enter a number between 65-100:");

        int score = int.Parse(Console.ReadLine());
        char grade = 'I';

        if (score == 100)
        {
            Console.WriteLine("A+!!");
            Console.WriteLine("Perfect score!!");
            grade = 'A';
            Console.WriteLine($"Your grade is {grade}.");
        }
        else
        {
            Console.WriteLine("Try again, dumbass!!");
        }

        int gameScore = 45; // This could change as the player progresses through the game.
        int pointsNeededToPass = 100;
        bool levelComplete;
        if (gameScore >= pointsNeededToPass)
            levelComplete = true;
        else
            levelComplete = false;
        if (levelComplete)
            Console.WriteLine("You've beaten the level!");

        //Or we can use pure logic within an expression without an 'if'

        gameScore = 100;
        pointsNeededToPass = 95;
        levelComplete = score >= pointsNeededToPass;

        if (levelComplete)
            Console.WriteLine("You passed the level!!");
        
        if (!levelComplete)
            Console.WriteLine("This level is not over yet!");

    }
}
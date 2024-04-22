namespace SimulaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxState box = BoxState.LockedClosed;
            string boxAction;
            

            while (true)
            {
                Console.WriteLine($"The current state of the box is {box}.  What would you like to do?");
                Console.WriteLine("Your options are to Lock, Unlock, Open, or Close");
                Console.WriteLine("If you would like to quit, enter 1.");
                
                if (box == BoxState.LockedClosed)
                {
                    boxAction = Console.ReadLine();
                    if (boxAction == "Unlock")
                    {
                        Console.WriteLine("You have unlocked the box.");
                        box = BoxState.UnlockedClosed;
                        continue;
                    }
                    if (boxAction == "1")
                    {
                        Console.WriteLine("Thank you for playing");
                        break;
                    }
                    else
                        Console.WriteLine("Please try again.");
                    continue;                    
                }
                if (box == BoxState.UnlockedClosed)
                {
                    boxAction = Console.ReadLine();
                    if (boxAction == "Open")
                    {
                        Console.WriteLine("You have opened the box.");
                        box = BoxState.Opened;
                        continue;
                    }
                    if(boxAction == "Lock")
                    {
                        Console.WriteLine("You have locked the box.");
                        box = BoxState.LockedClosed;
                        continue;
                    }
                    if (boxAction == "1")
                    {
                        Console.WriteLine("Thank you for playing.");
                        break;
                    }
                    else
                        Console.WriteLine("Please try again.");
                        continue;
                }
                if (box == BoxState.Opened)
                {
                    boxAction = Console.ReadLine();
                    if (boxAction == "Close")
                    {
                        Console.WriteLine("You have closed the box.");
                        box = BoxState.UnlockedClosed;
                        continue;
                    }
                    if (boxAction == "1")
                    {
                        Console.WriteLine("Thank you for playing");
                        break;
                    }
                    else
                        Console.WriteLine("Please try again.");
                    continue;
                }
                
            }
        }
    }

    enum BoxState {Opened, UnlockedClosed, LockedClosed}
}
namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilot = -1;
            while (pilot < 0 || pilot > 100)
            {
                Console.WriteLine("Mr. Pilot, could you give me a number between 0 - 100?");
                pilot = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            
            int hunter = -1;
            while (true)
            {
                Console.WriteLine("Hunter, lets see if you can find the correct number? Guess between 0 -100");
                hunter = int.Parse(Console.ReadLine());
                if (hunter == pilot)
                {
                    Console.WriteLine($"Congratulations!! You guessed {hunter} which was the pilot's number!!");
                    break;
                }
                if (hunter < pilot)
                {
                    Console.WriteLine("The pilot's number is a little higher.");
                    continue;
                }
                if (hunter > pilot)
                {
                    Console.WriteLine("The pilot's number is a little lower.");
                    continue;
                }

            }

        }
    }
}
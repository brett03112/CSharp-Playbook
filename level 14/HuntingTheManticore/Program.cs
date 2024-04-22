namespace HuntingTheManticore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manticoreHealth = 10;
            int cityHealth = 15;

            int round = 1;
            int range = 0;
            int playerRange = 0;
            Boolean targetHit = false;

            Console.WriteLine("Player 1, enter the range of the Manticore:  ");
            range = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Player 2, it is your turn.");

            while (true)
            {
                Console.WriteLine($"STATUS:  ROUND: {round} CITY HEALTH: {cityHealth}/15 MANTICORE HEALTH: {manticoreHealth}/10");
                if (round % 3 == 0 && round % 5 == 0)
                {
                    Console.WriteLine("Your shot is expected to do 10 points of damage this round.");
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    Console.WriteLine("Your shot is expected to do 3 points of damage this round.");
                }
                else
                    Console.WriteLine("Your shot is expected to do 1 point of damage this round.");

                
                Console.WriteLine("Player 2, enter your range to the target:  ");
                playerRange = int.Parse(Console.ReadLine());
                targetHit = guessRangeResult(range, playerRange);
                if (targetHit)
                {
                    manticoreHealth = calcDamage(round, manticoreHealth);
                }
                
                cityHealth--;
                round++;

                if (manticoreHealth <= 0)
                {
                    Console.WriteLine("Congratulations!! You have defeated the Manticore!!");
                    break;
                }
                if (cityHealth <= 0)
                {
                    Console.WriteLine("The city has been destroyed!! You are a failure and should kill yourself...");
                    break;
                }

            }
        }
        public static int calcDamage(int round, int manticoreHealth)
        {
            if (round % 3 == 0 && round % 5 == 0)
            {
                Console.WriteLine("You hit the Manticore with a powerful Fire and Electric blast!!");
                return manticoreHealth -= 10;
            }
            else if (round % 3 == 0)
            {
                Console.WriteLine("You hit the Manticore with a powerful Fire blast!!");
                return manticoreHealth -= 3;
            }
            else if (round % 5 == 0)
            {
                Console.WriteLine("You hit the Manticore with a powerful Electric blast!");
                return manticoreHealth -= 3;
            }
            else
            {
                Console.WriteLine("Your shot hit the Manticore!!");
                return manticoreHealth -= 1;
            }           

        }
        public static Boolean guessRangeResult(int range, int playerRange)
        {
            if (range == playerRange)
            {
                return true;
            }
            if (playerRange < range)
            {
                Console.WriteLine("Your shot fell short of the target!");
                return false;
            }
            else
            {
                Console.WriteLine("You overshot the Manticore!!");
                return false;
            }
        }
    }
}
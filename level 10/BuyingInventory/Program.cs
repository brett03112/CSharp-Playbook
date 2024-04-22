namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            


            Console.WriteLine("The following items are available:\r\n1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\nWhat number do you want to see the price of?");

            int choice = int.Parse(Console.ReadLine());
            string response;

            if (name == "Brett")
            {
                response = choice switch
                {
                    1 => "Rope is 5 gold",
                    2 => "Torches are 8 gold",
                    3 => "Climbing equipment is 12 gold",
                    4 => "Clean water is 1 gold",
                    5 => "A machete is 10 gold",
                    6 => "A canoe will set you back 100 gold",
                    7 => "Food supplies are 1 gold",
                    _ => "Unfortunately, we don't carry that",
                };
                Console.WriteLine(response);

            }

            else
            {
                response = choice switch
                {
                    1 => "Rope is 10 gold",
                    2 => "Torches are 16 gold",
                    3 => "Climbing equipment is 24 gold",
                    4 => "Clean water is 2 gold",
                    5 => "A machete is 20 gold",
                    6 => "A canoe will set you back 200 gold",
                    7 => "Food supplies are 2 gold",
                    _ => "Unfortunately, we don't carry that",
                };

                Console.WriteLine(response);
            }

        }
    }
}
namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Use 'csharprepl' from the cli to test
            Console.WriteLine("Press any key when you are ready to begin...");

            //Lets the program read a key without printing it
            Console.ReadKey(true);

            //ChAnges the title of the console window
            Console.Title = "Hello Fucker";


            Console.WriteLine("Hello, World!");

            //Allows for a beep to play.  Can be used for pitch and duration
            Console.Beep(440, 1500);

            //The ampersand allows the console to print everything afterwards verbatim
            Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt");

            int myFavoriteNumber = 9;
            Console.WriteLine($"My favorite number is {myFavoriteNumber}."); //string interpolation

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();

            //adding spaces for pretty printing before the word
            Console.WriteLine($"#1: {name1,20}");
            Console.WriteLine($"#2: {name2,20}");

            //white spaces after the word
            Console.WriteLine($"{name1,-20} - 1");
            Console.WriteLine($"{name2,-20} - 2");

            //gives Pi 3 digits after the decimal
            Console.WriteLine($"{Math.PI:0.000}");

            Console.WriteLine($"{42:#.##}");// Displays "42"
            Console.WriteLine($"{42.1234:#.##}");// Displays "42.12"

            float currentHealth = 4;
            float maxHealth = 9;
            Console.WriteLine($"{currentHealth / maxHealth:0.0%}"); // Displays "44.4%"
        }
    }
}
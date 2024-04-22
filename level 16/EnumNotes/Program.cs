namespace EnumNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Season current = Season.Summer;
            if (current == Season.Summer || current == Season.Winter)
                Console.WriteLine("Happy solstice!");
            else
                Console.WriteLine("Happy equinox!");
            //always put enums at the bottom of the file


        }
        enum Season {Winter, Spring, Summer, Fall }
    }
}
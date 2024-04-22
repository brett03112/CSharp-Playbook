/*
 * Create a point system for keeping track of provinces,
 * dutchies, and estates. 1 pt for estates, 3 for dutchies,
 * and 6 for provinces.
 */

namespace DominionOfKings
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Use 'csharprepl' from the cli to test
            int provinces, dutchies, estates = 0;
            
            Console.WriteLine("Please enter how many provinces you have?");
            provinces = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the amount of dutchies? ");
            dutchies = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of estates?");
            estates = int.Parse(Console.ReadLine());

            int total = (provinces * 6) + (dutchies * 3) + estates;

            Console.WriteLine("The total amount of points is " + total);
        }
    }
}
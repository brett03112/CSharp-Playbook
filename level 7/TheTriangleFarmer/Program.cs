/*
 * Computes the area of a triangle
 */ 

namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
			// Use 'csharprepl' from the cli to test
            Console.WriteLine("What is the height of your triangle?");
            string sHeight = Console.ReadLine();
            Console.WriteLine("What is the size of the base of your triangle?");
            string sBase = Console.ReadLine();

            double height = Convert.ToDouble(sHeight);
            double baseLength = Convert.ToDouble(sBase);
            double area = .5 * height * baseLength;

            Console.WriteLine("The area of your triange is " +  area);
        }
    }
}
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
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the size of the base of your triangle?");
            double baseLength = Convert.ToDouble(Console.ReadLine());

            double area = .5 * height * baseLength;

            Console.WriteLine("The area of your triange is " +  area);
        }
    }
}
/*
 * This program computes the number of eggs between four sisters
 * and returns how many each sister gets and how many are
 * left over for the duckbear.
 */

namespace ChocolateEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs have been gathered today? ");
            int eggs = int.Parse(Console.ReadLine());
            int sisters = 4;

            int eggsPerSister = eggs / sisters;
            int duckBear = eggs % sisters;

            Console.WriteLine("The amount of eggs each sister gets is " + eggsPerSister);
            Console.WriteLine("The duckbear gets " +  duckBear);
        }
    }
}